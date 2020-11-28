using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MemberCardSystem.Job;
using MemberCardSystem.Models;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberCardSystem
{
    public partial class MainForm : FrmWithTitle
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Buy_BtnClick(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm();
            buyForm.ShowDialog(this);
        }

        private void btn_AddCard_BtnClick(object sender, EventArgs e)
        {
            AddCardForm addCardForm = new AddCardForm();
            addCardForm.ShowDialog(this);
        }

        private void btn_CardList_BtnClick(object sender, EventArgs e)
        {
            CardListForm cardListForm = new CardListForm();
            cardListForm.ShowDialog(this);
        }

        private void btn_Config_BtnClick(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IScheduler scheduler;
            scheduler = new StdSchedulerFactory().GetScheduler().Result;
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<AutoBackupJob>().Build();

            // 创建一个触发器
            ITrigger trigger = TriggerBuilder.Create().WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(17, 00))
              .Build();
            scheduler.ScheduleJob(job, trigger);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
