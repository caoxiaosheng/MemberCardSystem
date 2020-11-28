using HZH_Controls.Forms;
using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class AddMoneyForm : MyFrmWithTitle
    {
        public AddMoneyForm(string cardId)
        {
            InitializeComponent();
            _cardId = cardId;
        }

        private readonly string _cardId;

        private async void btn_Ok_BtnClick(object sender, EventArgs e)
        {
            if(int.TryParse(txt_AddMoney.InputText,out var _addMoney) == false)
            {
                FrmDialog.ShowDialog(this, "请输入正确的金额");
                return;
            }
            if(FrmDialog.ShowDialog(this, $"请确定金额:{_addMoney}", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _cardId && item.IsActive);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                        return;
                    }
                    var totalMoney = card.Money + _addMoney;
                    card.Money = totalMoney;
                    var record = new BuyRecord
                    {
                        CardId = card.CardId,
                        Record = $"[充值]充值{_addMoney}元，剩余余额{totalMoney}",
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
