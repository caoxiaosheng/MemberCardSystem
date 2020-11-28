namespace MemberCardSystem
{
    partial class BuyForm
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
            this.txt_Number = new HZH_Controls.Controls.UCTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CardType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new HZH_Controls.Controls.UCBtnExt();
            this.gbx_Money = new System.Windows.Forms.GroupBox();
            this.txt_Remain = new HZH_Controls.Controls.UCTextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Deduct = new HZH_Controls.Controls.UCTextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MoneyTotalMoney = new HZH_Controls.Controls.UCTextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Buy = new HZH_Controls.Controls.UCBtnExt();
            this.gbx_Point = new System.Windows.Forms.GroupBox();
            this.txt_AddPoints = new HZH_Controls.Controls.UCTextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PointTotal = new HZH_Controls.Controls.UCTextBoxEx();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbx_Money.SuspendLayout();
            this.gbx_Point.SuspendLayout();
            this.SuspendLayout();
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
            this.txt_Number.Location = new System.Drawing.Point(123, 24);
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
            this.txt_Number.Size = new System.Drawing.Size(306, 42);
            this.txt_Number.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "卡号/手机号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Money);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_Points);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_CardType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Number);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找会员";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Money.Location = new System.Drawing.Point(478, 87);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(0, 21);
            this.lbl_Money.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "余额：";
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_Points.Location = new System.Drawing.Point(361, 87);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(0, 21);
            this.lbl_Points.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "积分：";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_UserName.Location = new System.Drawing.Point(221, 87);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(0, 21);
            this.lbl_UserName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "姓名：";
            // 
            // lbl_CardType
            // 
            this.lbl_CardType.AutoSize = true;
            this.lbl_CardType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_CardType.Location = new System.Drawing.Point(82, 87);
            this.lbl_CardType.Name = "lbl_CardType";
            this.lbl_CardType.Size = new System.Drawing.Size(0, 21);
            this.lbl_CardType.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "卡类型：";
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
            this.btn_Search.Location = new System.Drawing.Point(446, 24);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Search.RectWidth = 1;
            this.btn_Search.Size = new System.Drawing.Size(86, 42);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.TabStop = false;
            this.btn_Search.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Search.TipsText = "";
            this.btn_Search.BtnClick += new System.EventHandler(this.btn_Search_BtnClick);
            // 
            // gbx_Money
            // 
            this.gbx_Money.Controls.Add(this.txt_Remain);
            this.gbx_Money.Controls.Add(this.label6);
            this.gbx_Money.Controls.Add(this.txt_Deduct);
            this.gbx_Money.Controls.Add(this.label4);
            this.gbx_Money.Controls.Add(this.txt_MoneyTotalMoney);
            this.gbx_Money.Controls.Add(this.label3);
            this.gbx_Money.Location = new System.Drawing.Point(42, 234);
            this.gbx_Money.Name = "gbx_Money";
            this.gbx_Money.Size = new System.Drawing.Size(553, 175);
            this.gbx_Money.TabIndex = 14;
            this.gbx_Money.TabStop = false;
            this.gbx_Money.Text = "储值卡结账";
            // 
            // txt_Remain
            // 
            this.txt_Remain.BackColor = System.Drawing.Color.Transparent;
            this.txt_Remain.ConerRadius = 5;
            this.txt_Remain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Remain.DecLength = 2;
            this.txt_Remain.Enabled = false;
            this.txt_Remain.FillColor = System.Drawing.Color.Empty;
            this.txt_Remain.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Remain.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Remain.InputText = "";
            this.txt_Remain.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_Remain.IsFocusColor = true;
            this.txt_Remain.IsRadius = true;
            this.txt_Remain.IsShowClearBtn = true;
            this.txt_Remain.IsShowKeyboard = false;
            this.txt_Remain.IsShowRect = true;
            this.txt_Remain.IsShowSearchBtn = false;
            this.txt_Remain.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Remain.Location = new System.Drawing.Point(123, 124);
            this.txt_Remain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Remain.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Remain.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Remain.Name = "txt_Remain";
            this.txt_Remain.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Remain.PromptColor = System.Drawing.Color.Gray;
            this.txt_Remain.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Remain.PromptText = "";
            this.txt_Remain.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Remain.RectWidth = 1;
            this.txt_Remain.RegexPattern = "";
            this.txt_Remain.Size = new System.Drawing.Size(306, 42);
            this.txt_Remain.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(19, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "剩余应付";
            // 
            // txt_Deduct
            // 
            this.txt_Deduct.BackColor = System.Drawing.Color.Transparent;
            this.txt_Deduct.ConerRadius = 5;
            this.txt_Deduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Deduct.DecLength = 2;
            this.txt_Deduct.FillColor = System.Drawing.Color.Empty;
            this.txt_Deduct.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Deduct.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Deduct.InputText = "";
            this.txt_Deduct.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_Deduct.IsFocusColor = true;
            this.txt_Deduct.IsRadius = true;
            this.txt_Deduct.IsShowClearBtn = true;
            this.txt_Deduct.IsShowKeyboard = false;
            this.txt_Deduct.IsShowRect = true;
            this.txt_Deduct.IsShowSearchBtn = false;
            this.txt_Deduct.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Deduct.Location = new System.Drawing.Point(123, 77);
            this.txt_Deduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Deduct.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Deduct.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Deduct.Name = "txt_Deduct";
            this.txt_Deduct.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Deduct.PromptColor = System.Drawing.Color.Gray;
            this.txt_Deduct.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Deduct.PromptText = "";
            this.txt_Deduct.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Deduct.RectWidth = 1;
            this.txt_Deduct.RegexPattern = "";
            this.txt_Deduct.Size = new System.Drawing.Size(306, 42);
            this.txt_Deduct.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "卡内抵扣";
            // 
            // txt_MoneyTotalMoney
            // 
            this.txt_MoneyTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.txt_MoneyTotalMoney.ConerRadius = 5;
            this.txt_MoneyTotalMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MoneyTotalMoney.DecLength = 2;
            this.txt_MoneyTotalMoney.FillColor = System.Drawing.Color.Empty;
            this.txt_MoneyTotalMoney.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_MoneyTotalMoney.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_MoneyTotalMoney.InputText = "";
            this.txt_MoneyTotalMoney.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_MoneyTotalMoney.IsFocusColor = true;
            this.txt_MoneyTotalMoney.IsRadius = true;
            this.txt_MoneyTotalMoney.IsShowClearBtn = true;
            this.txt_MoneyTotalMoney.IsShowKeyboard = false;
            this.txt_MoneyTotalMoney.IsShowRect = true;
            this.txt_MoneyTotalMoney.IsShowSearchBtn = false;
            this.txt_MoneyTotalMoney.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_MoneyTotalMoney.Location = new System.Drawing.Point(123, 31);
            this.txt_MoneyTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MoneyTotalMoney.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_MoneyTotalMoney.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_MoneyTotalMoney.Name = "txt_MoneyTotalMoney";
            this.txt_MoneyTotalMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txt_MoneyTotalMoney.PromptColor = System.Drawing.Color.Gray;
            this.txt_MoneyTotalMoney.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_MoneyTotalMoney.PromptText = "";
            this.txt_MoneyTotalMoney.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_MoneyTotalMoney.RectWidth = 1;
            this.txt_MoneyTotalMoney.RegexPattern = "";
            this.txt_MoneyTotalMoney.Size = new System.Drawing.Size(306, 42);
            this.txt_MoneyTotalMoney.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "消费总额";
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
            this.btn_Buy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Buy.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Buy.IsRadius = true;
            this.btn_Buy.IsShowRect = true;
            this.btn_Buy.IsShowTips = false;
            this.btn_Buy.Location = new System.Drawing.Point(436, 425);
            this.btn_Buy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Buy.RectWidth = 1;
            this.btn_Buy.Size = new System.Drawing.Size(159, 42);
            this.btn_Buy.TabIndex = 14;
            this.btn_Buy.TabStop = false;
            this.btn_Buy.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Buy.TipsText = "";
            this.btn_Buy.BtnClick += new System.EventHandler(this.btn_Buy_BtnClick);
            // 
            // gbx_Point
            // 
            this.gbx_Point.Controls.Add(this.txt_AddPoints);
            this.gbx_Point.Controls.Add(this.label8);
            this.gbx_Point.Controls.Add(this.txt_PointTotal);
            this.gbx_Point.Controls.Add(this.label11);
            this.gbx_Point.Location = new System.Drawing.Point(42, 234);
            this.gbx_Point.Name = "gbx_Point";
            this.gbx_Point.Size = new System.Drawing.Size(553, 175);
            this.gbx_Point.TabIndex = 28;
            this.gbx_Point.TabStop = false;
            this.gbx_Point.Text = "积分卡结账";
            // 
            // txt_AddPoints
            // 
            this.txt_AddPoints.BackColor = System.Drawing.Color.Transparent;
            this.txt_AddPoints.ConerRadius = 5;
            this.txt_AddPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddPoints.DecLength = 2;
            this.txt_AddPoints.Enabled = false;
            this.txt_AddPoints.FillColor = System.Drawing.Color.Empty;
            this.txt_AddPoints.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_AddPoints.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AddPoints.InputText = "";
            this.txt_AddPoints.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_AddPoints.IsFocusColor = true;
            this.txt_AddPoints.IsRadius = true;
            this.txt_AddPoints.IsShowClearBtn = true;
            this.txt_AddPoints.IsShowKeyboard = false;
            this.txt_AddPoints.IsShowRect = true;
            this.txt_AddPoints.IsShowSearchBtn = false;
            this.txt_AddPoints.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_AddPoints.Location = new System.Drawing.Point(123, 108);
            this.txt_AddPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AddPoints.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_AddPoints.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_AddPoints.Name = "txt_AddPoints";
            this.txt_AddPoints.Padding = new System.Windows.Forms.Padding(5);
            this.txt_AddPoints.PromptColor = System.Drawing.Color.Gray;
            this.txt_AddPoints.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AddPoints.PromptText = "";
            this.txt_AddPoints.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_AddPoints.RectWidth = 1;
            this.txt_AddPoints.RegexPattern = "";
            this.txt_AddPoints.Size = new System.Drawing.Size(306, 42);
            this.txt_AddPoints.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(19, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "预计积分";
            // 
            // txt_PointTotal
            // 
            this.txt_PointTotal.BackColor = System.Drawing.Color.Transparent;
            this.txt_PointTotal.ConerRadius = 5;
            this.txt_PointTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PointTotal.DecLength = 2;
            this.txt_PointTotal.FillColor = System.Drawing.Color.Empty;
            this.txt_PointTotal.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_PointTotal.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PointTotal.InputText = "";
            this.txt_PointTotal.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_PointTotal.IsFocusColor = true;
            this.txt_PointTotal.IsRadius = true;
            this.txt_PointTotal.IsShowClearBtn = true;
            this.txt_PointTotal.IsShowKeyboard = false;
            this.txt_PointTotal.IsShowRect = true;
            this.txt_PointTotal.IsShowSearchBtn = false;
            this.txt_PointTotal.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_PointTotal.Location = new System.Drawing.Point(123, 43);
            this.txt_PointTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PointTotal.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_PointTotal.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_PointTotal.Name = "txt_PointTotal";
            this.txt_PointTotal.Padding = new System.Windows.Forms.Padding(5);
            this.txt_PointTotal.PromptColor = System.Drawing.Color.Gray;
            this.txt_PointTotal.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PointTotal.PromptText = "";
            this.txt_PointTotal.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_PointTotal.RectWidth = 1;
            this.txt_PointTotal.RegexPattern = "";
            this.txt_PointTotal.Size = new System.Drawing.Size(306, 42);
            this.txt_PointTotal.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label11.Location = new System.Drawing.Point(19, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "消费总额";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 476);
            this.Controls.Add(this.gbx_Point);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.gbx_Money);
            this.Controls.Add(this.groupBox1);
            this.IsShowCloseBtn = true;
            this.Name = "BuyForm";
            this.Text = "BuyForm";
            this.Title = "结账";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbx_Money, 0);
            this.Controls.SetChildIndex(this.btn_Buy, 0);
            this.Controls.SetChildIndex(this.gbx_Point, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_Money.ResumeLayout(false);
            this.gbx_Money.PerformLayout();
            this.gbx_Point.ResumeLayout(false);
            this.gbx_Point.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx txt_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CardType;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnExt btn_Search;
        private System.Windows.Forms.GroupBox gbx_Money;
        private HZH_Controls.Controls.UCTextBoxEx txt_Remain;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCTextBoxEx txt_Deduct;
        private System.Windows.Forms.Label label4;
        private HZH_Controls.Controls.UCTextBoxEx txt_MoneyTotalMoney;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCBtnExt btn_Buy;
        private System.Windows.Forms.GroupBox gbx_Point;
        private HZH_Controls.Controls.UCTextBoxEx txt_AddPoints;
        private System.Windows.Forms.Label label8;
        private HZH_Controls.Controls.UCTextBoxEx txt_PointTotal;
        private System.Windows.Forms.Label label11;
    }
}