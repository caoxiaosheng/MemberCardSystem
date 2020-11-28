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
    public partial class GiftsForm : FrmWithTitle
    {
        public GiftsForm()
        {
            InitializeComponent();
        }

        private async Task RefreshGifts()
        {
            using (var db = new MemberCardContext())
            {
                var _gifts = await db.Gifts.ToListAsync();
                dgv_Gifts.DataSource = (object)_gifts;
            }
        }

        private async void GiftsForm_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Id", HeadText = "礼物编号", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "GiftName", HeadText = "礼物名称", Width = 200, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Points", HeadText = "礼物分值", Width = 150, WidthType = SizeType.Absolute });
            dgv_Gifts.Columns = lstCulumns;
            dgv_Gifts.IsShowCheckBox = false;
            await RefreshGifts();
        }

        private async void btn_Add_BtnClick(object sender, EventArgs e)
        {
            FrmInputs frm = new FrmInputs("添加礼物",
                        new string[] { "礼物名称", "礼物分值" },
                        new Dictionary<string, HZH_Controls.TextInputType>() { { "礼物名称", HZH_Controls.TextInputType.NotControl }, { "礼物分值", HZH_Controls.TextInputType.Integer } },
                        new Dictionary<string, string>() { },
                        new Dictionary<string, KeyBoardType>() { },
                        new List<string>() { "礼物名称", "礼物分值"});
            
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var name = frm.Values[0];
                var points = frm.Values[1];
                if (int.TryParse(points, out var _giftPoints) == false)
                {
                    FrmDialog.ShowDialog(this, "礼物分值格式错误");
                    return;
                }
                using (var db = new MemberCardContext())
                {
                    var gift = new Gift()
                    {
                        GiftName = name,
                        Points = _giftPoints
                    };
                    db.Gifts.Add(gift);
                    await db.SaveChangesAsync();
                }
                await RefreshGifts();
            }
        }

        private async void btn_Remove_BtnClick(object sender, EventArgs e)
        {
            if (dgv_Gifts.SelectRow == null || dgv_Gifts.SelectRow.DataSource == null)
            {
                return;
            }
            var gift = dgv_Gifts.SelectRow.DataSource as Gift;
            if (gift == null)
            {
                return;
            }
            if (FrmDialog.ShowDialog(this, "确定删除吗", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var removeGift =await db.Gifts.FirstOrDefaultAsync(item => item.Id == gift.Id);
                    if (removeGift != null)
                    {
                        db.Gifts.Remove(removeGift);
                        await db.SaveChangesAsync();
                    }
                }
            }
            await RefreshGifts();
        }
    }
}
