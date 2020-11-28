using MemberCardSystem.Job;
using Quartz;
using Quartz.Impl;
using System;

namespace MemberCardSystem
{
    public partial class MainForm : MyFrmWithTitle
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

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            var recordForm = new RecordForm("");
            recordForm.ShowDialog(this);
        }
    }
}
