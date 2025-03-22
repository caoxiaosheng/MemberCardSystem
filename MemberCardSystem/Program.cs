using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberCardSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var db = new MemberCardContext())
            //{
            //    db.Database.ExecuteSqlRaw("CREATE INDEX \"IX_BuyRecords_CardId\" ON \"BuyRecords\" (\"CardId\");");
            //    db.Database.ExecuteSqlRaw("CREATE TABLE \"OldShoes\" (\r\n    \"Id\" INTEGER NOT NULL CONSTRAINT \"PK_OldShoes\" PRIMARY KEY AUTOINCREMENT,\r\n    \"CardId\" TEXT NULL,\r\n    \"Record\" TEXT NULL,\r\n    \"RecordTime\" TEXT NOT NULL,\r\n    \"DeleteTime\" TEXT NULL\r\n);");
            //    db.Database.ExecuteSqlRaw("CREATE INDEX \"IX_OldShoes_CardId\" ON \"OldShoes\" (\"CardId\");");
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
