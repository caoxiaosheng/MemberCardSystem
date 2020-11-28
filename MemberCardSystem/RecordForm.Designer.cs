namespace MemberCardSystem
{
    partial class RecordForm
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
            HZH_Controls.Controls.TimeLineItem timeLineItem1 = new HZH_Controls.Controls.TimeLineItem();
            HZH_Controls.Controls.TimeLineItem timeLineItem2 = new HZH_Controls.Controls.TimeLineItem();
            HZH_Controls.Controls.TimeLineItem timeLineItem3 = new HZH_Controls.Controls.TimeLineItem();
            HZH_Controls.Controls.TimeLineItem timeLineItem4 = new HZH_Controls.Controls.TimeLineItem();
            this.ucTimeLine = new HZH_Controls.Controls.UCTimeLine();
            this.SuspendLayout();
            // 
            // ucTimeLine
            // 
            this.ucTimeLine.AutoScroll = true;
            this.ucTimeLine.DetailsFont = new System.Drawing.Font("微软雅黑", 10F);
            this.ucTimeLine.DetailsForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.ucTimeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            timeLineItem1.Details = "2020年01月发生了一件大事，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷" +
    "，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，然后王二麻子他爹王咔嚓出生了。";
            timeLineItem1.Title = "2020年01月";
            timeLineItem2.Details = "2020年02月发生了一件大事，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷" +
    "，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，然后王二麻子他爹王咔嚓出生了。";
            timeLineItem2.Title = "2020年02月";
            timeLineItem3.Details = "2020年03月发生了一件大事，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷" +
    "，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，然后王二麻子他爹王咔嚓出生了。";
            timeLineItem3.Title = "2020年03月";
            timeLineItem4.Details = "2020年04月发生了一件大事，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷" +
    "，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，咔嚓一声打了一个炸雷，然后王二麻子他爹王咔嚓出生了。";
            timeLineItem4.Title = "2020年04月";
            this.ucTimeLine.Items = new HZH_Controls.Controls.TimeLineItem[] {
        timeLineItem1,
        timeLineItem2,
        timeLineItem3,
        timeLineItem4};
            this.ucTimeLine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.ucTimeLine.Location = new System.Drawing.Point(0, 61);
            this.ucTimeLine.Name = "ucTimeLine";
            this.ucTimeLine.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ucTimeLine.Size = new System.Drawing.Size(962, 507);
            this.ucTimeLine.TabIndex = 7;
            this.ucTimeLine.TitleFont = new System.Drawing.Font("微软雅黑", 14F);
            this.ucTimeLine.TitleForcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.ucTimeLine.Load += new System.EventHandler(this.ucTimeLine_Load);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 568);
            this.Controls.Add(this.ucTimeLine);
            this.IsShowCloseBtn = true;
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.Title = "记录";
            this.Controls.SetChildIndex(this.ucTimeLine, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCTimeLine ucTimeLine;
    }
}