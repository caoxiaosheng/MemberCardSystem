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
    public partial class OldShoesForm : MyFrmWithTitle
    {
        public OldShoesForm(string cardId)
        {
            InitializeComponent();
            _cardId = cardId;
        }

        private readonly string _cardId;

        private async void OldShoesForm_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Id", HeadText = "登记编号", Width = 50, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Record", HeadText = "登记信息", Width = 500, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "RecordTime", HeadText = "登记时间", Width = 150, WidthType = SizeType.Absolute });
            dgv_OldShoes.Columns = lstCulumns;
            dgv_OldShoes.IsShowCheckBox = false;
            await RefreshOldShoes();
        }

        private async Task RefreshOldShoes()
        {
            using (var db = new MemberCardContext())
            {
                var _oldShoes = await db.OldShoes.Where(item => item.CardId == _cardId && item.DeleteTime == null).ToListAsync();
                dgv_OldShoes.DataSource = (object)_oldShoes;
            }
        }

        private async void btn_Add_BtnClick(object sender, EventArgs e)
        {
            FrmInputs frm = new FrmInputs("登记旧鞋",
                        new string[] { "登记信息" },
                        new Dictionary<string, HZH_Controls.TextInputType>() { { "登记信息", HZH_Controls.TextInputType.NotControl } },
                        new Dictionary<string, string>() { },
                        new Dictionary<string, KeyBoardType>() { },
                        new List<string>() { "登记信息" });

            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var record = frm.Values[0];
                using (var db = new MemberCardContext())
                {
                    var oldshoes = new OldShoes()
                    {
                        CardId = _cardId,
                        Record = record,
                        RecordTime = DateTime.Now
                    };
                    db.OldShoes.Add(oldshoes);
                    await db.SaveChangesAsync();
                }
                await RefreshOldShoes();
            }
        }

        private async void btn_Remove_BtnClick(object sender, EventArgs e)
        {
            if (dgv_OldShoes.SelectRow == null || dgv_OldShoes.SelectRow.DataSource == null)
            {
                return;
            }
            var oldShoes = dgv_OldShoes.SelectRow.DataSource as OldShoes;
            if (oldShoes == null)
            {
                return;
            }
            if (FrmDialog.ShowDialog(this, "确定删除吗", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var removeGift = await db.OldShoes.FirstOrDefaultAsync(item => item.Id == oldShoes.Id);
                    if (removeGift != null)
                    {
                        removeGift.DeleteTime = DateTime.Now;
                        await db.SaveChangesAsync();
                    }
                }
            }
            await RefreshOldShoes();

        }

    }
}
