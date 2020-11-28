namespace MemberCardSystem
{
    partial class AddMoneyForm
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
            this.btn_Ok = new HZH_Controls.Controls.UCBtnExt();
            this.txt_AddMoney = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.White;
            this.btn_Ok.BtnBackColor = System.Drawing.Color.White;
            this.btn_Ok.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ok.BtnForeColor = System.Drawing.Color.White;
            this.btn_Ok.BtnText = "确定";
            this.btn_Ok.ConerRadius = 5;
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.EnabledMouseEffect = true;
            this.btn_Ok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Ok.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Ok.IsRadius = true;
            this.btn_Ok.IsShowRect = true;
            this.btn_Ok.IsShowTips = false;
            this.btn_Ok.Location = new System.Drawing.Point(373, 210);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Ok.RectWidth = 1;
            this.btn_Ok.Size = new System.Drawing.Size(86, 42);
            this.btn_Ok.TabIndex = 20;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Ok.TipsText = "";
            this.btn_Ok.BtnClick += new System.EventHandler(this.btn_Ok_BtnClick);
            // 
            // txt_AddMoney
            // 
            this.txt_AddMoney.BackColor = System.Drawing.Color.Transparent;
            this.txt_AddMoney.ConerRadius = 5;
            this.txt_AddMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddMoney.DecLength = 2;
            this.txt_AddMoney.FillColor = System.Drawing.Color.Empty;
            this.txt_AddMoney.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_AddMoney.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AddMoney.InputText = "";
            this.txt_AddMoney.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_AddMoney.IsFocusColor = true;
            this.txt_AddMoney.IsRadius = true;
            this.txt_AddMoney.IsShowClearBtn = true;
            this.txt_AddMoney.IsShowKeyboard = false;
            this.txt_AddMoney.IsShowRect = true;
            this.txt_AddMoney.IsShowSearchBtn = false;
            this.txt_AddMoney.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_AddMoney.Location = new System.Drawing.Point(157, 121);
            this.txt_AddMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AddMoney.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_AddMoney.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_AddMoney.Name = "txt_AddMoney";
            this.txt_AddMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txt_AddMoney.PromptColor = System.Drawing.Color.Gray;
            this.txt_AddMoney.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AddMoney.PromptText = "";
            this.txt_AddMoney.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_AddMoney.RectWidth = 1;
            this.txt_AddMoney.RegexPattern = "";
            this.txt_AddMoney.Size = new System.Drawing.Size(268, 42);
            this.txt_AddMoney.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "充值金额";
            // 
            // AddMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 303);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_AddMoney);
            this.Controls.Add(this.label1);
            this.IsShowCloseBtn = true;
            this.Name = "AddMoneyForm";
            this.Text = "AddMoneyForm";
            this.Title = "充值";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_AddMoney, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt btn_Ok;
        private HZH_Controls.Controls.UCTextBoxEx txt_AddMoney;
        private System.Windows.Forms.Label label1;
    }
}