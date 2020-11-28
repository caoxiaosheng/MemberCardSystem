namespace MemberCardSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.btn_Buy = new HZH_Controls.Controls.UCBtnExt();
            this.btn_AddCard = new HZH_Controls.Controls.UCBtnExt();
            this.btn_CardList = new HZH_Controls.Controls.UCBtnExt();
            this.btn_Config = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.White;
            this.btn_Buy.BtnBackColor = System.Drawing.Color.White;
            this.btn_Buy.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Buy.BtnForeColor = System.Drawing.Color.White;
            this.btn_Buy.BtnText = "结账";
            this.btn_Buy.ConerRadius = 5;
            this.btn_Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buy.EnabledMouseEffect = true;
            this.btn_Buy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.btn_Buy.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Buy.IsRadius = true;
            this.btn_Buy.IsShowRect = true;
            this.btn_Buy.IsShowTips = false;
            this.btn_Buy.Location = new System.Drawing.Point(211, 118);
            this.btn_Buy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Buy.RectWidth = 1;
            this.btn_Buy.Size = new System.Drawing.Size(184, 60);
            this.btn_Buy.TabIndex = 7;
            this.btn_Buy.TabStop = false;
            this.btn_Buy.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Buy.TipsText = "";
            this.btn_Buy.BtnClick += new System.EventHandler(this.btn_Buy_BtnClick);
            // 
            // btn_AddCard
            // 
            this.btn_AddCard.BackColor = System.Drawing.Color.White;
            this.btn_AddCard.BtnBackColor = System.Drawing.Color.White;
            this.btn_AddCard.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddCard.BtnForeColor = System.Drawing.Color.White;
            this.btn_AddCard.BtnText = "办卡";
            this.btn_AddCard.ConerRadius = 5;
            this.btn_AddCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCard.EnabledMouseEffect = true;
            this.btn_AddCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.btn_AddCard.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_AddCard.IsRadius = true;
            this.btn_AddCard.IsShowRect = true;
            this.btn_AddCard.IsShowTips = false;
            this.btn_AddCard.Location = new System.Drawing.Point(211, 316);
            this.btn_AddCard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddCard.Name = "btn_AddCard";
            this.btn_AddCard.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_AddCard.RectWidth = 1;
            this.btn_AddCard.Size = new System.Drawing.Size(184, 60);
            this.btn_AddCard.TabIndex = 8;
            this.btn_AddCard.TabStop = false;
            this.btn_AddCard.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_AddCard.TipsText = "";
            this.btn_AddCard.BtnClick += new System.EventHandler(this.btn_AddCard_BtnClick);
            // 
            // btn_CardList
            // 
            this.btn_CardList.BackColor = System.Drawing.Color.White;
            this.btn_CardList.BtnBackColor = System.Drawing.Color.White;
            this.btn_CardList.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CardList.BtnForeColor = System.Drawing.Color.White;
            this.btn_CardList.BtnText = "会员列表";
            this.btn_CardList.ConerRadius = 5;
            this.btn_CardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CardList.EnabledMouseEffect = true;
            this.btn_CardList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_CardList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_CardList.IsRadius = true;
            this.btn_CardList.IsShowRect = true;
            this.btn_CardList.IsShowTips = false;
            this.btn_CardList.Location = new System.Drawing.Point(544, 118);
            this.btn_CardList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_CardList.Name = "btn_CardList";
            this.btn_CardList.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_CardList.RectWidth = 1;
            this.btn_CardList.Size = new System.Drawing.Size(184, 60);
            this.btn_CardList.TabIndex = 10;
            this.btn_CardList.TabStop = false;
            this.btn_CardList.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_CardList.TipsText = "";
            this.btn_CardList.BtnClick += new System.EventHandler(this.btn_CardList_BtnClick);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.White;
            this.btn_Config.BtnBackColor = System.Drawing.Color.White;
            this.btn_Config.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Config.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_Config.BtnText = "设置";
            this.btn_Config.ConerRadius = 5;
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.EnabledMouseEffect = true;
            this.btn_Config.FillColor = System.Drawing.Color.White;
            this.btn_Config.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Config.IsRadius = true;
            this.btn_Config.IsShowRect = true;
            this.btn_Config.IsShowTips = false;
            this.btn_Config.Location = new System.Drawing.Point(544, 316);
            this.btn_Config.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Config.RectWidth = 1;
            this.btn_Config.Size = new System.Drawing.Size(184, 60);
            this.btn_Config.TabIndex = 10;
            this.btn_Config.TabStop = false;
            this.btn_Config.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Config.TipsText = "";
            this.btn_Config.BtnClick += new System.EventHandler(this.btn_Config_BtnClick);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "近期消费记录";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(376, 488);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Gainsboro;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(184, 60);
            this.ucBtnExt1.TabIndex = 11;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 608);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_CardList);
            this.Controls.Add(this.btn_AddCard);
            this.Controls.Add(this.btn_Buy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "MainForm";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "MainForm";
            this.Title = "会员卡管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.btn_Buy, 0);
            this.Controls.SetChildIndex(this.btn_AddCard, 0);
            this.Controls.SetChildIndex(this.btn_CardList, 0);
            this.Controls.SetChildIndex(this.btn_Config, 0);
            this.Controls.SetChildIndex(this.ucBtnExt1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
        private HZH_Controls.Controls.UCBtnExt btn_Buy;
        private HZH_Controls.Controls.UCBtnExt btn_AddCard;
        private HZH_Controls.Controls.UCBtnExt btn_CardList;
        private HZH_Controls.Controls.UCBtnExt btn_Config;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
    }
}

