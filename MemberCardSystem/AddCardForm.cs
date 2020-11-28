using HZH_Controls.Forms;
using MemberCardSystem.Models;
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
    public partial class AddCardForm : FrmWithTitle
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private async void btn_Ok_BtnClick(object sender, EventArgs e)
        {
            this.Enabled = false;
            var id = txt_CardId.InputText;
            var phoneNumber = txt_PhoneNumber.InputText;
            var cardType = (CardType)Enum.Parse(typeof(CardType), cbx_CardType.TextValue);
            var userName = txt_UserName.InputText;
            if (string.IsNullOrWhiteSpace(id))
            {
                FrmDialog.ShowDialog(this, "卡号不能为空");
                this.Enabled = true;
                return;
            }
            using (var db = new MemberCardContext())
            {
                if (db.Cards.Any(item => item.CardId == id))
                {
                    FrmDialog.ShowDialog(this, "卡号已存在");
                    this.Enabled = true;
                    return;
                }
                //20201108移除手机号重复限制
                //if (string.IsNullOrWhiteSpace(phoneNumber) == false)
                //{
                //    if (db.Cards.Any(item => item.IsActive == true && item.PhoneNumber == phoneNumber))
                //    {
                //        FrmDialog.ShowDialog(this, "手机号已存在");
                //        this.Enabled = true;
                //        return;
                //    }
                //}
                var card = new Card { CardId = id, PhoneNumber = phoneNumber, CardType = cardType, UserName = userName, Money = 0, Points = 0, IsActive = true };
                db.Cards.Add(card);
                await db.SaveChangesAsync();
            }
            Close();
        }

        private void btn_Cancle_BtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCardForm_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            var cardTypes = Enum.GetNames(typeof(CardType));
            for (int i = 0; i < cardTypes.Length; i++)
            {
                lstCom.Add(new KeyValuePair<string, string>(i.ToString(), cardTypes[i]));
            }
            cbx_CardType.Source = lstCom;
            cbx_CardType.SelectedIndex = 0;
        }
    }
}
