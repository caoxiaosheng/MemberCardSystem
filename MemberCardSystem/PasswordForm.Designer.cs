namespace MemberCardSystem
{
    partial class PasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new HZH_Controls.Controls.UCTextBoxEx();
            this.btn_Ok = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.ConerRadius = 5;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DecLength = 2;
            this.txt_Password.FillColor = System.Drawing.Color.Empty;
            this.txt_Password.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Password.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.InputText = "";
            this.txt_Password.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_Password.IsFocusColor = true;
            this.txt_Password.IsRadius = true;
            this.txt_Password.IsShowClearBtn = true;
            this.txt_Password.IsShowKeyboard = false;
            this.txt_Password.IsShowRect = true;
            this.txt_Password.IsShowSearchBtn = false;
            this.txt_Password.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Password.Location = new System.Drawing.Point(118, 112);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Password.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Password.PromptColor = System.Drawing.Color.Gray;
            this.txt_Password.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.PromptText = "";
            this.txt_Password.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Password.RectWidth = 1;
            this.txt_Password.RegexPattern = "";
            this.txt_Password.Size = new System.Drawing.Size(268, 42);
            this.txt_Password.TabIndex = 15;
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
            this.btn_Ok.Location = new System.Drawing.Point(334, 201);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Ok.RectWidth = 1;
            this.btn_Ok.Size = new System.Drawing.Size(86, 42);
            this.btn_Ok.TabIndex = 17;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Ok.TipsText = "";
            this.btn_Ok.BtnClick += new System.EventHandler(this.btn_Ok_BtnClick);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 263);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.IsShowCloseBtn = true;
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.Title = "输入密码";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_Password, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCTextBoxEx txt_Password;
        private HZH_Controls.Controls.UCBtnExt btn_Ok;
    }
}