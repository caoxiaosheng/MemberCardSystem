using HZH_Controls.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemberCardSystem
{
    public partial class RecordForm : MyFrmWithTitle
    {
        public RecordForm(string cardId)
        {
            InitializeComponent();
            ucTimeLine.Items = new TimeLineItem[0];
            _cardId = cardId;
        }

        private readonly string _cardId;

        private async void ucTimeLine_Load(object sender, System.EventArgs e)
        {
            List<TimeLineItem> items = new List<TimeLineItem>();
            using (var db = new MemberCardContext())
            {
                if (String.IsNullOrWhiteSpace(_cardId))
                {
                    //没传 认为是查近一百条消费记录
                    dynamic records = await db.BuyRecords.OrderByDescending(item => item.Id).Join(db.Cards,b=>b.CardId,c=>c.CardId,(b,c)=>new {Info=b,Name=c.UserName }).Take(100).ToListAsync();
                    foreach (var record in records)
                    {
                        items.Add(new TimeLineItem { Title = record.Info.RecordTime.ToString("yyyy-MM-dd HH:mm:ss"), Details =record.Info.CardId+" "+ record.Name + "    " +record.Info.Record });
                    }
                }
                else
                {
                    var records = await db.BuyRecords.Where(item => item.CardId == _cardId).OrderByDescending(item => item.Id).ToListAsync();
                    foreach (var record in records)
                    {
                        items.Add(new TimeLineItem { Title = record.RecordTime.ToString("yyyy-MM-dd HH:mm:ss"), Details = record.Record });
                    }
                }
                
            }
            if (items.Count == 0)
            {
                items.Add(new TimeLineItem() { Title = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Details = "无消费记录" });
            }
            ucTimeLine.Items = items.ToArray();
        }
    }
}
