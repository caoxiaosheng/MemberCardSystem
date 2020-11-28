using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class BuyForm : FrmWithTitle 
    { 
        public BuyForm()
        {
            InitializeComponent();
            txt_MoneyTotalMoney.TextChanged += Txt_MoneyTotalMoney_TextChanged;
            txt_Deduct.TextChanged += Txt_Deduct_TextChanged;
            txt_PointTotal.TextChanged += Txt_PointTotal_TextChanged;
        }

        private CardType cardType = CardType.积分卡;
        private int remainMoney = 0;
        private string currentId=null;
        private double _deductPercent = 0.1;
        private void Txt_PointTotal_TextChanged(object sender, EventArgs e)
        {
            txt_AddPoints.InputText = txt_PointTotal.InputText;
        }

        private void Txt_Deduct_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_MoneyTotalMoney.InputText, out var _totalMoney)&& int.TryParse(txt_Deduct.InputText, out var _deduct))
            {
                txt_Remain.InputText = (_totalMoney - _deduct).ToString();
            }
        }

        private void Txt_MoneyTotalMoney_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txt_MoneyTotalMoney.InputText,out var _totalMoney))
            {
                var deduct = (int)(_totalMoney * _deductPercent);
                var realDeduct = Math.Min(deduct, remainMoney);
                txt_Deduct.InputText = realDeduct.ToString();
                txt_Remain.InputText = (_totalMoney - realDeduct).ToString();
            }
        }

        private async void btn_Search_BtnClick(object sender, EventArgs e)
        {
            await Search();
        }

        private async void btn_Buy_BtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentId))
            {
                FrmDialog.ShowDialog(this, "请先查询用户");
                return;
            }
            btn_Buy.Enabled = false;
            if (cardType == CardType.积分卡)
            {
                await BuyPoint();
            }
            else
            {
                await BuyMoney();
            }
            btn_Buy.Enabled = true;
        }

        private async Task BuyPoint()
        {
            if (int.TryParse(txt_AddPoints.InputText, out var _addPoints) == false||_addPoints<0)
            {
                FrmDialog.ShowDialog(this, "请输入正确的金额");
                return;
            }
            using (var db = new MemberCardContext())
            {
                var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == currentId && item.IsActive);
                if (card== null)
                {
                    FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                    return;
                }
                int remainPoints = card.Points + _addPoints;
                card.Points = remainPoints;
                var record = new BuyRecord
                {
                    CardId=card.CardId,
                    Record = $"[积分消费]消费{_addPoints}元，积分{_addPoints}分，剩余总积分{remainPoints}",
                    RecordTime = DateTime.Now
                };
                db.BuyRecords.Add(record);
                await db.SaveChangesAsync();
                this.Close();
            }
        }

        private async Task BuyMoney()
        {
            if (int.TryParse(txt_Deduct.InputText, out var _deduct) == false || _deduct < 0)
            {
                FrmDialog.ShowDialog(this, "请输入正确的折扣金额");
                return;
            }
            if (int.TryParse(txt_Remain.InputText, out var _remain) == false || _remain < 0)
            {
                FrmDialog.ShowDialog(this, "请输入正确的金额");
                return;
            }
            if (_deduct > remainMoney)
            {
                FrmDialog.ShowDialog(this, "余额不足");
                return;
            }
            using (var db = new MemberCardContext())
            {
                var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == currentId && item.IsActive);
                if (card == null)
                {
                    FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                    return;
                }
                var remainMoney = card.Money - _deduct;
                card.Money = remainMoney;
                var record = new BuyRecord
                {
                    CardId = card.CardId,
                    Record = $"[余额消费]消费{txt_MoneyTotalMoney.InputText}元，余额抵扣{_deduct}元，实付{_remain}元，剩余余额{remainMoney}",
                    RecordTime = DateTime.Now
                };
                db.BuyRecords.Add(record);
                await db.SaveChangesAsync();
                this.Close();
            }
        }

        private async Task Search()
        {
            var number = txt_Number.InputText;
            if (string.IsNullOrWhiteSpace(number))
            {
                ClearLabel();
                return;
            }
            using (var db = new MemberCardContext())
            {
                var cards = await db.Cards.Where(item => (item.CardId == number || item.PhoneNumber == number)&&item.IsActive).ToListAsync();
                if (cards.Count()==0)
                {
                    FrmDialog.ShowDialog(this, "未找到该会员卡，可能不存在或者被锁定");
                    ClearLabel();
                    return;
                }
                if (cards.Count() > 1)
                {
                    FrmDialog.ShowDialog(this, "找到多张卡片，请联系管理员修复数据");
                    ClearLabel();
                    return;
                }
                var card = cards[0];
                lbl_CardType.Text = card.CardType.ToString() ;
                lbl_UserName.Text = card.UserName;
                lbl_Points.Text = card.Points.ToString();
                lbl_Money.Text = card.Money.ToString();
                txt_Deduct.MaxValue = card.Money;
                remainMoney= card.Money;
                cardType = card.CardType;
                currentId = card.CardId;
                ShowGroupBox(cardType);
            }
        }

        private void ClearLabel()
        {
            lbl_CardType.Text = "";
            lbl_UserName.Text = "";
            lbl_Points.Text = "";
            lbl_Money.Text = "";
            currentId = null;
        }

        private void ShowGroupBox(CardType cardType)
        {
            if (cardType == CardType.储值卡)
            {
                foreach (var control in gbx_Point.Controls)
                {
                    if(control is UCTextBoxEx)
                    {
                        var textBox = control as UCTextBoxEx;
                        textBox.InputText = string.Empty;
                    }
                }
                gbx_Point.Visible = false;
                gbx_Money.Visible = true;
            }
            else
            {
                foreach (var control in gbx_Money.Controls)
                {
                    if (control is UCTextBoxEx)
                    {
                        var textBox = control as UCTextBoxEx;
                        textBox.InputText = string.Empty;
                    }
                }
                gbx_Money.Visible = false;
                gbx_Point.Visible = true;
            }
        }

        protected async override void DoEnter()
        {
            await Search();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            using (var db = new MemberCardContext())
            {
                var per = db.Configs.FirstOrDefault(item => item.Key == ConfigName.DeductPerCent.ToString());
                if (per != null&&int.TryParse(per.Value,out var perValue))
                {
                    _deductPercent = perValue / (double)100;
                }
            }
        }
    }
}
