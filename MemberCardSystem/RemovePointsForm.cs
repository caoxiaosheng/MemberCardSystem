using HZH_Controls.Forms;
using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class RemovePointsForm : MyFrmWithTitle
    {
        public RemovePointsForm(string cardId)
        {
            InitializeComponent();
            _cardId = cardId;
        }

        private readonly string _cardId;

        private async void btn_Ok_BtnClick(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Points.InputText, out var _points) == false)
            {
                FrmDialog.ShowDialog(this, "请输入正确的积分");
                return;
            }
            if (FrmDialog.ShowDialog(this, $"请确定积分:{_points}", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _cardId && item.IsActive);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                        return;
                    }
                    if (card.Points < _points)
                    {
                        FrmDialog.ShowDialog(this, $"积分不足，仅剩{card.Points}分");
                        return;
                    }
                    var remainPoints = card.Points - _points;
                    card.Points = remainPoints;
                    var remarks = "";
                    if (string.IsNullOrWhiteSpace(txt_Remarks.InputText))
                    {
                        remarks = "无";
                    }
                    else
                    {
                        remarks = txt_Remarks.InputText;
                    }
                    var record = new BuyRecord
                    {
                        CardId = card.CardId,
                        Record = $"[扣积分]扣积分{_points}分，备注：{remarks}，剩余积分{remainPoints}",
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
