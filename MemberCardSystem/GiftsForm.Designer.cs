namespace MemberCardSystem
{
    partial class GiftsForm
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
            this.dgv_Gifts = new HZH_Controls.Controls.UCDataGridView();
            this.btn_Add = new HZH_Controls.Controls.UCBtnExt();
            this.btn_Remove = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // dgv_Gifts
            // 
            this.dgv_Gifts.AutoScroll = true;
            this.dgv_Gifts.BackColor = System.Drawing.Color.White;
            this.dgv_Gifts.Columns = null;
            this.dgv_Gifts.DataSource = null;
            this.dgv_Gifts.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_Gifts.HeadHeight = 40;
            this.dgv_Gifts.HeadPadingLeft = 0;
            this.dgv_Gifts.HeadTextColor = System.Drawing.Color.Black;
            this.dgv_Gifts.IsShowCheckBox = false;
            this.dgv_Gifts.IsShowHead = true;
            this.dgv_Gifts.Location = new System.Drawing.Point(34, 160);
            this.dgv_Gifts.Name = "dgv_Gifts";
            this.dgv_Gifts.RowHeight = 40;
            this.dgv_Gifts.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.dgv_Gifts.Size = new System.Drawing.Size(608, 349);
            this.dgv_Gifts.TabIndex = 20;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.BtnBackColor = System.Drawing.Color.White;
            this.btn_Add.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.BtnForeColor = System.Drawing.Color.White;
            this.btn_Add.BtnText = "添加";
            this.btn_Add.ConerRadius = 5;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.EnabledMouseEffect = true;
            this.btn_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Add.IsRadius = true;
            this.btn_Add.IsShowRect = true;
            this.btn_Add.IsShowTips = false;
            this.btn_Add.Location = new System.Drawing.Point(406, 86);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Add.RectWidth = 1;
            this.btn_Add.Size = new System.Drawing.Size(86, 42);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.TabStop = false;
            this.btn_Add.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Add.TipsText = "";
            this.btn_Add.BtnClick += new System.EventHandler(this.btn_Add_BtnClick);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.BtnBackColor = System.Drawing.Color.White;
            this.btn_Remove.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Remove.BtnForeColor = System.Drawing.Color.White;
            this.btn_Remove.BtnText = "删除";
            this.btn_Remove.ConerRadius = 5;
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.EnabledMouseEffect = true;
            this.btn_Remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.btn_Remove.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Remove.IsRadius = true;
            this.btn_Remove.IsShowRect = true;
            this.btn_Remove.IsShowTips = false;
            this.btn_Remove.Location = new System.Drawing.Point(538, 86);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.RectColor = System.Drawing.Color.Gainsboro;
            this.btn_Remove.RectWidth = 1;
            this.btn_Remove.Size = new System.Drawing.Size(86, 42);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_Remove.TipsText = "";
            this.btn_Remove.BtnClick += new System.EventHandler(this.btn_Remove_BtnClick);
            // 
            // GiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 521);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Gifts);
            this.IsShowCloseBtn = true;
            this.Name = "GiftsForm";
            this.Text = "GiftsForm";
            this.Title = "礼物设置";
            this.Load += new System.EventHandler(this.GiftsForm_Load);
            this.Controls.SetChildIndex(this.dgv_Gifts, 0);
            this.Controls.SetChildIndex(this.btn_Add, 0);
            this.Controls.SetChildIndex(this.btn_Remove, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDataGridView dgv_Gifts;
        private HZH_Controls.Controls.UCBtnExt btn_Add;
        private HZH_Controls.Controls.UCBtnExt btn_Remove;
    }
}