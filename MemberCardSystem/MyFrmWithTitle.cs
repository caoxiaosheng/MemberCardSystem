using HZH_Controls.Forms;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class MyFrmWithTitle : FrmWithTitle
    {
        public MyFrmWithTitle()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
