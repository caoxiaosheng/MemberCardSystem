namespace MemberCardSystem
{
    partial class CardSelectForm
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
            this.cbx_Cards = new HZH_Controls.Controls.UCCombox();
            this.btn_Ok = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(95, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "卡片";
            // 
            // cbx_Cards
            // 
            this.cbx_Cards.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Cards.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbx_Cards.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cards.ConerRadius = 5;
            this.cbx_Cards.DropPanelHeight = -1;
            this.cbx_Cards.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbx_Cards.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbx_Cards.IsRadius = true;
            this.cbx_Cards.IsShowRect = true;
            this.cbx_Cards.ItemWidth = 70;
            this.cbx_Cards.Location = new System.Drawing.Point(191, 97);
            this.cbx_Cards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Cards.Name = "cbx_Cards";
            this.cbx_Cards.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbx_Cards.RectWidth = 1;
            this.cbx_Cards.SelectedIndex = -1;
            this.cbx_Cards.SelectedValue = "";
            this.cbx_Cards.Size = new System.Drawing.Size(463, 42);
            this.cbx_Cards.Source = null;
            this.cbx_Cards.TabIndex = 13;
            this.cbx_Cards.TextValue = null;
            this.cbx_Cards.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
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
            this.btn_Ok.Location = new System.Drawing.Point(568, 183);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Ok.RectWidth = 1;
            this.btn_Ok.Size = new System.Drawing.Size(86, 42);
            this.btn_Ok.TabIndex = 22;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Ok.TipsText = "";
            this.btn_Ok.BtnClick += new System.EventHandler(this.btn_Ok_BtnClick);
            // 
            // CardSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 265);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Cards);
            this.IsShowCloseBtn = true;
            this.Name = "CardSelectForm";
            this.Text = "CardSelectForm";
            this.Title = "选择卡片";
            this.Load += new System.EventHandler(this.CardSelectForm_Load);
            this.Controls.SetChildIndex(this.cbx_Cards, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCCombox cbx_Cards;
        private HZH_Controls.Controls.UCBtnExt btn_Ok;
    }
}