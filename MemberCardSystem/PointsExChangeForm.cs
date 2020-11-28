using HZH_Controls.Forms;
using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class PointsExChangeForm : MyFrmWithTitle
    {
        public PointsExChangeForm(string cardId)
        {
            this._cardId = cardId;
            InitializeComponent();
        }

        private readonly string _cardId;
        private List<Gift> _gifts=new List<Gift>();

        private async Task RefreshGifts()
        {
            using (var db = new MemberCardContext())
            {
                _gifts=await db.Gifts.ToListAsync();
            }
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < _gifts.Count; i++)
            {
                lstCom.Add(new KeyValuePair<string, string>(i.ToString(), _gifts[i].GiftName+" " + _gifts[i].Points+"分"));
            }
            cbx_Gifts.Source = lstCom;
            if (lstCom.Count > 0)
            {
                cbx_Gifts.SelectedIndex = 0;
            }
        }

        private async void PointsExChangeForm_Load(object sender, EventArgs e)
        {
            await RefreshGifts();
        }

        private async void btn_ConfigGifts_BtnClick(object sender, EventArgs e)
        {
            var giftsForm = new GiftsForm();
            giftsForm.ShowDialog(this);
            await RefreshGifts();
        }

        private async void btn_Ok_BtnClickAsync(object sender, EventArgs e)
        {
            var index = cbx_Gifts.SelectedIndex;
            if (index < 0 || index >= _gifts.Count)
            {
                FrmDialog.ShowDialog(this, "请先选择礼物");
                return;
            }
            var gift = _gifts[index];
            using (var db = new MemberCardContext())
            {
                var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _cardId && item.IsActive);
                if (card == null)
                {
                    FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                    return;
                }
                if (card.Points < gift.Points)
                {
                    FrmDialog.ShowDialog(this, $"积分不足，仅剩{card.Points}分");
                    return;
                }
                if (FrmDialog.ShowDialog(this, $"是否兑换礼物:{gift.GiftName}", "提示", true) == DialogResult.OK)
                {
                    var remainPoints = card.Points - gift.Points;
                    card.Points = remainPoints;
                    var record = new BuyRecord
                    {
                        CardId = card.CardId,
                        Record = $"[积分兑换]兑换礼物{gift.GiftName}，扣积分{gift.Points}分，剩余积分{remainPoints}",
                        RecordTime = DateTime.Now
                    };
                    db.BuyRecords.Add(record);
                    await db.SaveChangesAsync();
                    this.Close();
                }
            }
        }

    }
}
