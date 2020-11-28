using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberCardSystem.Job
{
    class AutoBackupJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            using (var db = new MemberCardContext())
            {
                var path = db.Configs.FirstOrDefault(item => item.Key == ConfigName.BackupPath.ToString());
                if (path != null)
                {
                    try
                    {
                        var source = "db";
                        var dst = "db" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        dst = Path.Combine(path.Value, dst);
                        CopyDirectInfo(source, dst);
                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                }
            }
            return Task.CompletedTask;
        }

        public static void CopyDirectInfo(string sourceDir, string toDir)
        {
            if (!Directory.Exists(sourceDir))
            {
                throw new ApplicationException("Source directory does not exist");
            }
            if (!Directory.Exists(toDir))
            {
                Directory.CreateDirectory(toDir);
            }
            DirectoryInfo directInfo = new DirectoryInfo(sourceDir);
            //copy files
            FileInfo[] filesInfos = directInfo.GetFiles();
            foreach (FileInfo fileinfo in filesInfos)
            {
                string fileName = fileinfo.Name;
                File.Copy(fileinfo.FullName, toDir + @"/" + fileName, true);
            }
        }
    }
}
