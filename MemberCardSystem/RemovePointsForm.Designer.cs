namespace MemberCardSystem
{
    partial class RemovePointsForm
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
            this.txt_Points = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Remarks = new HZH_Controls.Controls.UCTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btn_Ok.Location = new System.Drawing.Point(411, 297);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Ok.RectWidth = 1;
            this.btn_Ok.Size = new System.Drawing.Size(86, 42);
            this.btn_Ok.TabIndex = 23;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Ok.TipsText = "";
            this.btn_Ok.BtnClick += new System.EventHandler(this.btn_Ok_BtnClick);
            // 
            // txt_Points
            // 
            this.txt_Points.BackColor = System.Drawing.Color.Transparent;
            this.txt_Points.ConerRadius = 5;
            this.txt_Points.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Points.DecLength = 2;
            this.txt_Points.FillColor = System.Drawing.Color.Empty;
            this.txt_Points.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Points.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Points.InputText = "";
            this.txt_Points.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_Points.IsFocusColor = true;
            this.txt_Points.IsRadius = true;
            this.txt_Points.IsShowClearBtn = true;
            this.txt_Points.IsShowKeyboard = false;
            this.txt_Points.IsShowRect = true;
            this.txt_Points.IsShowSearchBtn = false;
            this.txt_Points.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Points.Location = new System.Drawing.Point(173, 124);
            this.txt_Points.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Points.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Points.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Points.Name = "txt_Points";
            this.txt_Points.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Points.PromptColor = System.Drawing.Color.Gray;
            this.txt_Points.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Points.PromptText = "";
            this.txt_Points.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Points.RectWidth = 1;
            this.txt_Points.RegexPattern = "";
            this.txt_Points.Size = new System.Drawing.Size(268, 42);
            this.txt_Points.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "扣积分";
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.txt_Remarks.ConerRadius = 5;
            this.txt_Remarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Remarks.DecLength = 2;
            this.txt_Remarks.FillColor = System.Drawing.Color.Empty;
            this.txt_Remarks.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Remarks.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Remarks.InputText = "";
            this.txt_Remarks.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_Remarks.IsFocusColor = true;
            this.txt_Remarks.IsRadius = true;
            this.txt_Remarks.IsShowClearBtn = true;
            this.txt_Remarks.IsShowKeyboard = false;
            this.txt_Remarks.IsShowRect = true;
            this.txt_Remarks.IsShowSearchBtn = false;
            this.txt_Remarks.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Remarks.Location = new System.Drawing.Point(173, 196);
            this.txt_Remarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Remarks.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Remarks.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Remarks.PromptColor = System.Drawing.Color.Gray;
            this.txt_Remarks.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Remarks.PromptText = "";
            this.txt_Remarks.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Remarks.RectWidth = 1;
            this.txt_Remarks.RegexPattern = "";
            this.txt_Remarks.Size = new System.Drawing.Size(268, 42);
            this.txt_Remarks.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "备注";
            // 
            // RemovePointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 379);
            this.Controls.Add(this.txt_Remarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_Points);
            this.Controls.Add(this.label1);
            this.IsShowCloseBtn = true;
            this.Name = "RemovePointsForm";
            this.Text = "RemovePointsForm";
            this.Title = "扣积分";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_Points, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_Remarks, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt btn_Ok;
        private HZH_Controls.Controls.UCTextBoxEx txt_Points;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCTextBoxEx txt_Remarks;
        private System.Windows.Forms.Label label2;
    }
}