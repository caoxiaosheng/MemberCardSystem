namespace MemberCardSystem
{
    partial class ConfigForm
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
            this.txt_DeductPer = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Path = new HZH_Controls.Controls.UCTextBoxEx();
            this.btn_Select = new HZH_Controls.Controls.UCBtnExt();
            this.btn_Save = new HZH_Controls.Controls.UCBtnExt();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DeductPer
            // 
            this.txt_DeductPer.BackColor = System.Drawing.Color.Transparent;
            this.txt_DeductPer.ConerRadius = 5;
            this.txt_DeductPer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DeductPer.DecLength = 2;
            this.txt_DeductPer.FillColor = System.Drawing.Color.Empty;
            this.txt_DeductPer.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_DeductPer.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DeductPer.InputText = "";
            this.txt_DeductPer.InputType = HZH_Controls.TextInputType.Integer;
            this.txt_DeductPer.IsFocusColor = true;
            this.txt_DeductPer.IsRadius = true;
            this.txt_DeductPer.IsShowClearBtn = true;
            this.txt_DeductPer.IsShowKeyboard = false;
            this.txt_DeductPer.IsShowRect = true;
            this.txt_DeductPer.IsShowSearchBtn = false;
            this.txt_DeductPer.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_DeductPer.Location = new System.Drawing.Point(190, 95);
            this.txt_DeductPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DeductPer.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_DeductPer.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_DeductPer.Name = "txt_DeductPer";
            this.txt_DeductPer.Padding = new System.Windows.Forms.Padding(5);
            this.txt_DeductPer.PromptColor = System.Drawing.Color.Gray;
            this.txt_DeductPer.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_DeductPer.PromptText = "";
            this.txt_DeductPer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_DeductPer.RectWidth = 1;
            this.txt_DeductPer.RegexPattern = "";
            this.txt_DeductPer.Size = new System.Drawing.Size(182, 42);
            this.txt_DeductPer.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "储值卡抵扣百分比";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "自动备份路径";
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.Transparent;
            this.txt_Path.ConerRadius = 5;
            this.txt_Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Path.DecLength = 2;
            this.txt_Path.FillColor = System.Drawing.Color.Empty;
            this.txt_Path.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txt_Path.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Path.InputText = "";
            this.txt_Path.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_Path.IsFocusColor = true;
            this.txt_Path.IsRadius = true;
            this.txt_Path.IsShowClearBtn = true;
            this.txt_Path.IsShowKeyboard = false;
            this.txt_Path.IsShowRect = true;
            this.txt_Path.IsShowSearchBtn = false;
            this.txt_Path.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txt_Path.Location = new System.Drawing.Point(82, 235);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Path.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_Path.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Path.PromptColor = System.Drawing.Color.Gray;
            this.txt_Path.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Path.PromptText = "";
            this.txt_Path.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_Path.RectWidth = 1;
            this.txt_Path.RegexPattern = "";
            this.txt_Path.Size = new System.Drawing.Size(394, 42);
            this.txt_Path.TabIndex = 22;
            // 
            // btn_Select
            // 
            this.btn_Select.BackColor = System.Drawing.Color.White;
            this.btn_Select.BtnBackColor = System.Drawing.Color.White;
            this.btn_Select.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.BtnForeColor = System.Drawing.Color.White;
            this.btn_Select.BtnText = "选择路径";
            this.btn_Select.ConerRadius = 5;
            this.btn_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Select.EnabledMouseEffect = true;
            this.btn_Select.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Select.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Select.IsRadius = true;
            this.btn_Select.IsShowRect = true;
            this.btn_Select.IsShowTips = false;
            this.btn_Select.Location = new System.Drawing.Point(382, 178);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Select.RectWidth = 1;
            this.btn_Select.Size = new System.Drawing.Size(86, 42);
            this.btn_Select.TabIndex = 24;
            this.btn_Select.TabStop = false;
            this.btn_Select.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Select.TipsText = "";
            this.btn_Select.BtnClick += new System.EventHandler(this.btn_Select_BtnClick);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BtnBackColor = System.Drawing.Color.White;
            this.btn_Save.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.BtnForeColor = System.Drawing.Color.White;
            this.btn_Save.BtnText = "保存";
            this.btn_Save.ConerRadius = 5;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.EnabledMouseEffect = true;
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Save.IsRadius = true;
            this.btn_Save.IsShowRect = true;
            this.btn_Save.IsShowTips = false;
            this.btn_Save.Location = new System.Drawing.Point(433, 343);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.RectWidth = 1;
            this.btn_Save.Size = new System.Drawing.Size(86, 42);
            this.btn_Save.TabIndex = 25;
            this.btn_Save.TabStop = false;
            this.btn_Save.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Save.TipsText = "";
            this.btn_Save.BtnClick += new System.EventHandler(this.btn_Save_BtnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "配置路径后每天下午5点自动备份";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DeductPer);
            this.Controls.Add(this.label1);
            this.IsShowCloseBtn = true;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Title = "设置";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_DeductPer, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_Path, 0);
            this.Controls.SetChildIndex(this.btn_Select, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx txt_DeductPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCTextBoxEx txt_Path;
        private HZH_Controls.Controls.UCBtnExt btn_Select;
        private HZH_Controls.Controls.UCBtnExt btn_Save;
        private System.Windows.Forms.Label label4;
    }
}