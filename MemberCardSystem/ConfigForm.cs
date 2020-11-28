using HZH_Controls.Forms;
using System.Linq;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class ConfigForm : FrmWithTitle
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private async void btn_Save_BtnClick(object sender, System.EventArgs e)
        {
            using (var db = new MemberCardContext())
            {
                var per = db.Configs.FirstOrDefault(item => item.Key == ConfigName.DeductPerCent.ToString());
                if (per == null)
                {
                    db.Configs.Add(new Models.Config() { Key = ConfigName.DeductPerCent.ToString(), Value = txt_DeductPer.InputText });
                }
                else
                {
                    per.Value = txt_DeductPer.InputText;
                }
                var path = db.Configs.FirstOrDefault(item => item.Key == ConfigName.BackupPath.ToString());
                if (path == null)
                {
                    db.Configs.Add(new Models.Config() { Key = ConfigName.BackupPath.ToString(), Value = txt_Path.InputText });
                }
                else
                {
                    path.Value = txt_Path.InputText;
                }
                await db.SaveChangesAsync();
                this.Close();
            }
        }

        private void btn_Select_BtnClick(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.Description = "请选择自动备份文件夹";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txt_Path.InputText = dialog.SelectedPath;
                }
            }
        }

        private void ConfigForm_Load(object sender, System.EventArgs e)
        {
            using (var db = new MemberCardContext())
            {
                var per = db.Configs.FirstOrDefault(item => item.Key == ConfigName.DeductPerCent.ToString());
                if (per == null)
                {
                    txt_DeductPer.InputText = "10";
                }
                else
                {
                    txt_DeductPer.InputText=per.Value;
                }
                var path = db.Configs.FirstOrDefault(item => item.Key == ConfigName.BackupPath.ToString());
                if (path == null)
                {
                    txt_Path.InputText = "";
                }
                else
                {
                    txt_Path.InputText = path.Value;
                }
            }
        }
    }
}
