namespace MemberCardSystem
{
    partial class CardListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardListForm));
            this.btn_Search = new HZH_Controls.Controls.UCBtnExt();
            this.txt_Number = new HZH_Controls.Controls.UCTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Input = new HZH_Controls.Controls.UCBtnExt();
            this.btn_Output = new HZH_Controls.Controls.UCBtnExt();
            this.dgv_Cards = new HZH_Controls.Controls.UCDataGridView();
            this.pageControl = new HZH_Controls.Controls.UCPagerControl2();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_RemovePoints = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PointsExChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AddMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_DoActive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ChangeToMoney = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ChangeToPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ChangeCardInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.BtnBackColor = System.Drawing.Color.White;
            this.btn_Search.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Search.BtnForeColor = System.Drawing.Color.White;
            this.btn_Search.BtnText = "查询";
            this.btn_Search.ConerRadius = 5;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.EnabledMouseEffect = true;
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Search.IsRadius = true;
            this.btn_Search.IsShowRect = true;
            this.btn_Search.IsShowTips = false;
            this.btn_Search.Location = new System.Drawing.Point(409, 69);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Search.RectWidth = 1;
            this.btn_Search.Size = new System.Drawing.Size(86, 42);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.TabStop = false;
            this.btn_Search.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Search.TipsText = "";
            this.btn_Search.BtnClick += new System.EventHandler(this.btn_Search_BtnClick);
            // 
            // txt_Number
            // 
            this.txt_Number.BackColor = System.Drawing.Color.Transparent;
            this.txt_Number.ConerRadius = 5;
            this.txt_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Number.DecLength = 2;
            this.txt_Number.FillColor = System.Drawing.Color.Empty;
            this.txt_Number.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Number.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Number.InputText = "";
            this.txt_Number.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_Number.IsFocusColor = true;
            this.txt_Number.IsRadius = true;
            this.txt_Number.IsShowClearBtn = true;
            this.txt_Number.IsShowKeyboard = false;
            this.txt_Number.IsShowRect = true;
            this.txt_Number.IsShowSearchBtn = false;
            this.txt_Number.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Number.Location = new System.Drawing.Point(116, 69);
            this.txt_Number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Number.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Number.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Number.PromptColor = System.Drawing.Color.Gray;
            this.txt_Number.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Number.PromptText = "";
            this.txt_Number.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Number.RectWidth = 1;
            this.txt_Number.RegexPattern = "";
            this.txt_Number.Size = new System.Drawing.Size(268, 42);
            this.txt_Number.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "卡号/手机号";
            // 
            // btn_Input
            // 
            this.btn_Input.BackColor = System.Drawing.Color.White;
            this.btn_Input.BtnBackColor = System.Drawing.Color.White;
            this.btn_Input.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Input.BtnForeColor = System.Drawing.Color.White;
            this.btn_Input.BtnText = "批量导入";
            this.btn_Input.ConerRadius = 5;
            this.btn_Input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Input.EnabledMouseEffect = true;
            this.btn_Input.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Input.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Input.IsRadius = true;
            this.btn_Input.IsShowRect = true;
            this.btn_Input.IsShowTips = false;
            this.btn_Input.Location = new System.Drawing.Point(911, 69);
            this.btn_Input.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Input.RectWidth = 1;
            this.btn_Input.Size = new System.Drawing.Size(136, 42);
            this.btn_Input.TabIndex = 17;
            this.btn_Input.TabStop = false;
            this.btn_Input.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Input.TipsText = "";
            this.btn_Input.BtnClick += new System.EventHandler(this.btn_Input_BtnClick);
            // 
            // btn_Output
            // 
            this.btn_Output.BackColor = System.Drawing.Color.White;
            this.btn_Output.BtnBackColor = System.Drawing.Color.White;
            this.btn_Output.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Output.BtnForeColor = System.Drawing.Color.White;
            this.btn_Output.BtnText = "导出表格";
            this.btn_Output.ConerRadius = 5;
            this.btn_Output.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Output.EnabledMouseEffect = true;
            this.btn_Output.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Output.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Output.IsRadius = true;
            this.btn_Output.IsShowRect = true;
            this.btn_Output.IsShowTips = false;
            this.btn_Output.Location = new System.Drawing.Point(756, 69);
            this.btn_Output.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Output.Name = "btn_Output";
            this.btn_Output.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Output.RectWidth = 1;
            this.btn_Output.Size = new System.Drawing.Size(126, 42);
            this.btn_Output.TabIndex = 18;
            this.btn_Output.TabStop = false;
            this.btn_Output.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Output.TipsText = "";
            this.btn_Output.BtnClick += new System.EventHandler(this.btn_Output_BtnClick);
            // 
            // dgv_Cards
            // 
            this.dgv_Cards.AutoScroll = true;
            this.dgv_Cards.BackColor = System.Drawing.Color.White;
            this.dgv_Cards.Columns = null;
            this.dgv_Cards.DataSource = null;
            this.dgv_Cards.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_Cards.HeadHeight = 40;
            this.dgv_Cards.HeadPadingLeft = 0;
            this.dgv_Cards.HeadTextColor = System.Drawing.Color.Black;
            this.dgv_Cards.IsShowCheckBox = false;
            this.dgv_Cards.IsShowHead = true;
            this.dgv_Cards.Location = new System.Drawing.Point(12, 119);
            this.dgv_Cards.Name = "dgv_Cards";
            this.dgv_Cards.RowHeight = 40;
            this.dgv_Cards.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.dgv_Cards.Size = new System.Drawing.Size(1032, 484);
            this.dgv_Cards.TabIndex = 19;
            this.dgv_Cards.ItemClick += new HZH_Controls.Controls.DataGridViewEventHandler(this.dgv_Cards_ItemClick);
            // 
            // pageControl
            // 
            this.pageControl.BackColor = System.Drawing.Color.White;
            this.pageControl.DataSource = ((System.Collections.Generic.List<object>)(resources.GetObject("pageControl.DataSource")));
            this.pageControl.Location = new System.Drawing.Point(135, 609);
            this.pageControl.Name = "pageControl";
            this.pageControl.PageCount = 0;
            this.pageControl.PageIndex = 1;
            this.pageControl.PageModel = HZH_Controls.Controls.PageModel.Soure;
            this.pageControl.PageSize = 10;
            this.pageControl.Size = new System.Drawing.Size(921, 41);
            this.pageControl.StartIndex = 0;
            this.pageControl.TabIndex = 20;
            this.pageControl.ShowSourceChanged += new HZH_Controls.Controls.PageControlEventHandler(this.pageControl_ShowSourceChanged);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(86, 624);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(63, 17);
            this.lbl_Total.TabIndex = 22;
            this.lbl_Total.Text = "共0条数据";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Log,
            this.tsm_RemovePoints,
            this.tsm_PointsExChange,
            this.tsm_AddMoney,
            this.tsm_DoActive,
            this.tsm_ChangeToMoney,
            this.tsm_ChangeToPoint,
            this.tsm_Delete,
            this.tsm_ChangeCardInfo});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 224);
            this.contextMenuStrip.Text = "查看记录";
            // 
            // tsm_Log
            // 
            this.tsm_Log.Name = "tsm_Log";
            this.tsm_Log.Size = new System.Drawing.Size(180, 22);
            this.tsm_Log.Text = "查看记录";
            this.tsm_Log.Click += new System.EventHandler(this.tsm_Log_Click);
            // 
            // tsm_RemovePoints
            // 
            this.tsm_RemovePoints.Name = "tsm_RemovePoints";
            this.tsm_RemovePoints.Size = new System.Drawing.Size(180, 22);
            this.tsm_RemovePoints.Text = "扣积分";
            this.tsm_RemovePoints.Click += new System.EventHandler(this.tsm_RemovePoints_Click);
            // 
            // tsm_PointsExChange
            // 
            this.tsm_PointsExChange.Name = "tsm_PointsExChange";
            this.tsm_PointsExChange.Size = new System.Drawing.Size(180, 22);
            this.tsm_PointsExChange.Text = "积分兑换";
            this.tsm_PointsExChange.Click += new System.EventHandler(this.tsm_PointsExChange_Click);
            // 
            // tsm_AddMoney
            // 
            this.tsm_AddMoney.Name = "tsm_AddMoney";
            this.tsm_AddMoney.Size = new System.Drawing.Size(180, 22);
            this.tsm_AddMoney.Text = "充值";
            this.tsm_AddMoney.Click += new System.EventHandler(this.tsm_AddMoney_Click);
            // 
            // tsm_DoActive
            // 
            this.tsm_DoActive.Name = "tsm_DoActive";
            this.tsm_DoActive.Size = new System.Drawing.Size(180, 22);
            this.tsm_DoActive.Text = "锁定/解锁";
            this.tsm_DoActive.Click += new System.EventHandler(this.tsm_DoActive_Click);
            // 
            // tsm_ChangeToMoney
            // 
            this.tsm_ChangeToMoney.Name = "tsm_ChangeToMoney";
            this.tsm_ChangeToMoney.Size = new System.Drawing.Size(180, 22);
            this.tsm_ChangeToMoney.Text = "转储值卡";
            this.tsm_ChangeToMoney.Click += new System.EventHandler(this.tsm_ChangeToMoney_Click);
            // 
            // tsm_ChangeToPoint
            // 
            this.tsm_ChangeToPoint.Name = "tsm_ChangeToPoint";
            this.tsm_ChangeToPoint.Size = new System.Drawing.Size(180, 22);
            this.tsm_ChangeToPoint.Text = "转积分卡";
            this.tsm_ChangeToPoint.Click += new System.EventHandler(this.tsm_ChangeToPoint_Click);
            // 
            // tsm_Delete
            // 
            this.tsm_Delete.Name = "tsm_Delete";
            this.tsm_Delete.Size = new System.Drawing.Size(180, 22);
            this.tsm_Delete.Text = "删除会员";
            this.tsm_Delete.Click += new System.EventHandler(this.tsm_Delete_Click);
            // 
            // tsm_ChangeCardInfo
            // 
            this.tsm_ChangeCardInfo.Name = "tsm_ChangeCardInfo";
            this.tsm_ChangeCardInfo.Size = new System.Drawing.Size(180, 22);
            this.tsm_ChangeCardInfo.Text = "修改会员信息";
            this.tsm_ChangeCardInfo.Click += new System.EventHandler(this.tsm_ChangeCardInfo_Click);
            // 
            // CardListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 653);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.pageControl);
            this.Controls.Add(this.dgv_Cards);
            this.Controls.Add(this.btn_Output);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.label2);
            this.IsShowCloseBtn = true;
            this.Name = "CardListForm";
            this.Text = "CardListForm";
            this.Title = "会员列表";
            this.Load += new System.EventHandler(this.CardListForm_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_Number, 0);
            this.Controls.SetChildIndex(this.btn_Search, 0);
            this.Controls.SetChildIndex(this.btn_Input, 0);
            this.Controls.SetChildIndex(this.btn_Output, 0);
            this.Controls.SetChildIndex(this.dgv_Cards, 0);
            this.Controls.SetChildIndex(this.pageControl, 0);
            this.Controls.SetChildIndex(this.lbl_Total, 0);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt btn_Search;
        private HZH_Controls.Controls.UCTextBoxEx txt_Number;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt btn_Input;
        private HZH_Controls.Controls.UCBtnExt btn_Output;
        private HZH_Controls.Controls.UCDataGridView dgv_Cards;
        private HZH_Controls.Controls.UCPagerControl2 pageControl;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_Log;
        private System.Windows.Forms.ToolStripMenuItem tsm_RemovePoints;
        private System.Windows.Forms.ToolStripMenuItem tsm_PointsExChange;
        private System.Windows.Forms.ToolStripMenuItem tsm_AddMoney;
        private System.Windows.Forms.ToolStripMenuItem tsm_DoActive;
        private System.Windows.Forms.ToolStripMenuItem tsm_ChangeToMoney;
        private System.Windows.Forms.ToolStripMenuItem tsm_ChangeToPoint;
        private System.Windows.Forms.ToolStripMenuItem tsm_Delete;
        private System.Windows.Forms.ToolStripMenuItem tsm_ChangeCardInfo;
    }
}