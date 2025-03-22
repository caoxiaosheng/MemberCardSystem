using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;

namespace MemberCardSystem
{
    public partial class CardListForm : MyFrmWithTitle
    {
        public CardListForm()
        {
            InitializeComponent();
        }

        private Card _currentCard = null;
        private List<Card> _cards = new List<Card>();

        private void CardListForm_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "CardId", HeadText = "会员卡号", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "PhoneNumber", HeadText = "手机号码", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "UserName", HeadText = "会员姓名", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "CardType", HeadText = "卡类型", Width = 100, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Points", HeadText = "当前积分", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Money", HeadText = "余额", Width = 150, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "IsActive", HeadText = "会员卡状态", Width = 150, WidthType = SizeType.Absolute, Format = (a) => { return ((bool)a) == true ? "正常" : "锁定"; } });
            dgv_Cards.Columns = lstCulumns;
            dgv_Cards.IsShowCheckBox = false;
        }

        private async void btn_Search_BtnClick(object sender, EventArgs e)
        {
            await Search();
        }

        private async Task Search()
        {
            var number = txt_Number.InputText;
            using (var db = new MemberCardContext())
            {
                _cards = new List<Card>();
                if (string.IsNullOrWhiteSpace(number))
                {
                    _cards = await db.Cards.ToListAsync();
                }
                else
                {
                    _cards = await db.Cards.Where(item => item.CardId == number || item.PhoneNumber == number).ToListAsync();
                }
                pageControl.DataSource = _cards.Select(item=>(object)item).ToList();
                lbl_Total.Text = $"共{_cards.Count}条数据";
            }
        }

        private void pageControl_ShowSourceChanged(object currentSource)
        {
            dgv_Cards.DataSource = currentSource;
        }

        private void dgv_Cards_ItemClick(object sender, DataGridViewEventArgs e)
        {
            if(dgv_Cards.SelectRow==null|| dgv_Cards.SelectRow.DataSource == null)
            {
                _currentCard = null;
                return;
            }
            var card = dgv_Cards.SelectRow.DataSource as Card;
            if (card == null)
            {
                _currentCard = null;
                return;
            }
            _currentCard = card;
            if (_currentCard.CardType == CardType.储值卡)
            {
                tsm_AddMoney.Visible = true;
                tsm_RemovePoints.Visible = false;
                tsm_PointsExChange.Visible = false;
                tsm_ChangeToMoney.Visible = false;
                tsm_ChangeToPoint.Visible = true;
            }
            else
            {
                tsm_AddMoney.Visible = false;
                tsm_RemovePoints.Visible = true;
                tsm_PointsExChange.Visible = true;
                tsm_ChangeToMoney.Visible = true;
                tsm_ChangeToPoint.Visible = false;
            }
            contextMenuStrip.Show(MousePosition);
        }

        private void tsm_Log_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            var recordForm = new RecordForm(_currentCard.CardId);
            recordForm.ShowDialog(this);
        }

        private async void tsm_AddMoney_Click(object sender, EventArgs e)
        {
            PasswordForm password = new PasswordForm();
            if (password.ShowDialog(this) == DialogResult.OK)
            {
                if (_currentCard == null)
                {
                    return;
                }
                var addMoneyForm = new AddMoneyForm(_currentCard.CardId);
                addMoneyForm.ShowDialog(this);
                await Search();
            }
        }

        private async void tsm_RemovePoints_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            var recordForm = new RemovePointsForm(_currentCard.CardId);
            recordForm.ShowDialog(this);
            await Search();
        }

        private async void tsm_PointsExChange_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            var pointsExChangeForm = new PointsExChangeForm(_currentCard.CardId);
            pointsExChangeForm.ShowDialog(this);
            await Search();
        }

        private async void tsm_DoActive_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            if (FrmDialog.ShowDialog(this, $"请确定{(_currentCard.IsActive?"锁定":"解锁")}", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _currentCard.CardId && item.IsActive== _currentCard.IsActive);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡");
                        return;
                    }
                    card.IsActive = !card.IsActive;
                    await db.SaveChangesAsync();
                }
                await Search();
            }
        }

        private async void tsm_ChangeToMoney_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            if (FrmDialog.ShowDialog(this, $"请确定切换为储值卡？", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _currentCard.CardId);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡");
                        return;
                    }
                    if (card.Points != 0)
                    {
                        FrmDialog.ShowDialog(this, "该会员卡还有积分，不允许转换");
                        return;
                    }
                    card.CardType = CardType.储值卡;
                    await db.SaveChangesAsync();
                }
                await Search();
            }
        }

        private async void tsm_ChangeToPoint_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            if (FrmDialog.ShowDialog(this, $"请确定切换为积分卡？", "提示", true) == DialogResult.OK)
            {
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _currentCard.CardId);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡");
                        return;
                    }
                    if (card.Money != 0)
                    {
                        FrmDialog.ShowDialog(this, "该会员卡还有余额，不允许转换");
                        return;
                    }
                    card.CardType = CardType.积分卡;
                    await db.SaveChangesAsync();
                }
                await Search();
            }
        }

        private async void tsm_Delete_Click(object sender, EventArgs e)
        {
            PasswordForm password = new PasswordForm();
            if (password.ShowDialog(this) == DialogResult.OK)
            {
                if (_currentCard == null)
                {
                    return;
                }
                if (FrmDialog.ShowDialog(this, $"确定删除:{_currentCard.CardId}({_currentCard.PhoneNumber},{_currentCard.UserName})及相关消费记录?", "提示", true) == DialogResult.OK)
                {
                    using (var db = new MemberCardContext())
                    {
                        var cards = db.Cards.Where(item => item.CardId == _currentCard.CardId);
                        var logs = db.BuyRecords.Where(item => item.CardId == _currentCard.CardId);
                        db.Cards.RemoveRange(cards);
                        db.BuyRecords.RemoveRange(logs);
                        await db.SaveChangesAsync();
                    }
                    await Search();
                }
            }
        }

        protected async override void DoEnter()
        {
            await Search();
        }

        private void btn_Output_BtnClick(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel表格（*.xlsx）|*.xlsx";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;
                sfd.FileName = "会员卡数据" + DateTime.Now.ToString("yyyyMMddHHmmss");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var workbook = ReoGridControl.CreateMemoryWorkbook();
                    var sheet = workbook.Worksheets[0];
                    sheet.SetRows(_cards.Count + 2);
                    sheet.SetCols(7);
                    sheet[0, 0] = "会员卡号";
                    sheet[0, 1] = "手机号码";
                    sheet[0,2] = "会员姓名";
                    sheet[0, 3] = "卡类型";
                    sheet[0,4] = "当前积分";
                    sheet[0, 5] = "余额";
                    sheet[0, 6] = "会员卡状态";
                    for (int i = 0; i < _cards.Count; i++)
                    {
                        sheet[i + 1, 0] = _cards[i].CardId;
                        sheet[i + 1, 1] = _cards[i].PhoneNumber;
                        sheet[i + 1, 2] = _cards[i].UserName;
                        sheet[i + 1, 3] = _cards[i].CardType;
                        sheet[i + 1, 4] = _cards[i].Points;
                        sheet[i + 1, 5] = _cards[i].Money;
                        sheet[i + 1, 6] = _cards[i].IsActive == true ? "正常" : "锁定";
                    }
                    try
                    {
                        workbook.Save(sfd.FileName);
                        FrmDialog.ShowDialog(this, "导出成功");
                    }
                    catch (Exception ex)
                    {
                        FrmDialog.ShowDialog(this, ex.Message);
                    }
                }
            }
        }

        private async void btn_Input_BtnClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Title = "请选择文件";
                dialog.Filter = "Excel表格（*.xlsx）|*.xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = dialog.FileName;
                    try
                    {
                        var workbook = ReoGridControl.CreateMemoryWorkbook();
                        workbook.Load(file);
                        var sheet = workbook.Worksheets[0];
                        List<Card> cards = new List<Card>();
                        for (int i = 1; i < sheet.RowCount; i++)
                        {
                            if (string.IsNullOrEmpty(sheet[i, 0].GetString()) == false  && int.TryParse(sheet[i, 4].GetString(), out var points))
                            {
                                var card = new Card()
                                {
                                    CardId = sheet[i, 0].GetString(),
                                    PhoneNumber = sheet[i, 1].GetString(),
                                    UserName = sheet[i, 2].GetString(),
                                    CardType = CardType.积分卡,
                                    Points = points,
                                    Money = 0,
                                    IsActive = sheet[i, 6].GetString() == "正常" ? true : false
                                };
                                cards.Add(card);
                            }
                        }
                        using (var db = new MemberCardContext())
                        {
                            db.Cards.AddRange(cards);
                            await db.SaveChangesAsync();
                        }
                        FrmDialog.ShowDialog(this, "导入成功");
                    }
                    catch (Exception ex)
                    {
                        FrmDialog.ShowDialog(this, ex.Message);
                    }
                }
            }
        }

        //20201108新增修改会员信息
        private async void tsm_ChangeCardInfo_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            FrmInputs frm = new FrmInputs("修改会员信息",
                        new string[] { "手机号码", "会员姓名" },
                        new Dictionary<string, HZH_Controls.TextInputType>() { { "手机号码", HZH_Controls.TextInputType.NotControl }, { "会员姓名", HZH_Controls.TextInputType.NotControl } },
                        new Dictionary<string, string>() { },
                        new Dictionary<string, KeyBoardType>() { },
                        new List<string>() { "礼物名称", "礼物分值" },
                        new Dictionary<string, string>() { { "手机号码", _currentCard.PhoneNumber }, { "会员姓名", _currentCard.UserName } });
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var phoneNumber = frm.Values[0];
                var userName = frm.Values[1];
                using (var db = new MemberCardContext())
                {
                    var card = await db.Cards.FirstOrDefaultAsync(item => item.CardId == _currentCard.CardId);
                    if (card == null)
                    {
                        FrmDialog.ShowDialog(this, "未找到该会员卡");
                        return;
                    }
                    card.PhoneNumber = phoneNumber;
                    card.UserName = userName;
                    await db.SaveChangesAsync();
                }
                await Search();
            }
        }

        private void tsm_RecordOldShoes_Click(object sender, EventArgs e)
        {
            if (_currentCard == null)
            {
                return;
            }
            var oldShoesForm = new OldShoesForm(_currentCard.CardId);
            oldShoesForm.ShowDialog(this);
        }
    }
}

static class SheetExtension
{
    public static string GetString(this object sheetData)
    {
        if (sheetData == null)
        {
            return string.Empty;
        }
        else
        {
            return sheetData.ToString();
        }
    }
}


