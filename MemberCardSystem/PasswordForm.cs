using HZH_Controls.Forms;
using System;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class PasswordForm : MyFrmWithTitle
    {
        public PasswordForm()
        {
            InitializeComponent();
            txt_Password.txtInput.PasswordChar ='*';
        }

        private void btn_Ok_BtnClick(object sender, EventArgs e)
        {
            if (txt_Password.InputText == "yf123321")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                FrmDialog.ShowDialog(this, "密码错误");
                return;
            }
        }
    }
}
