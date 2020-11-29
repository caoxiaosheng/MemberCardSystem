using HZH_Controls.Forms;
using MemberCardSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class CardSelectForm : MyFrmWithTitle
    {
        public CardSelectForm(List<Card> cards)
        {
            _cards = cards;
            InitializeComponent();
        }

        private List<Card> _cards = new List<Card>();
        private int _selectedIndex;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
        }

        private void CardSelectForm_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < _cards.Count; i++)
            {
                lstCom.Add(new KeyValuePair<string, string>(i.ToString(), _cards[i].CardType+ _cards[i].CardId +" " + _cards[i].UserName + " " + _cards[i].PhoneNumber));
            }
            cbx_Cards.Source = lstCom;
            if (lstCom.Count > 0)
            {
                cbx_Cards.SelectedIndex = 0;
            }
        }

        private void btn_Ok_BtnClick(object sender, EventArgs e)
        {
            var index = cbx_Cards.SelectedIndex;
            if (index < 0 || index >= _cards.Count)
            {
                FrmDialog.ShowDialog(this, "请先选择卡片");
                return;
            }
            _selectedIndex = index;
            this.DialogResult = DialogResult.OK;
        }
    }
}
