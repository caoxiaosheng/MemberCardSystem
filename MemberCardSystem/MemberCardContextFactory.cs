using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberCardSystem
{
    public class MemberCardContextFactory : IDesignTimeDbContextFactory<MemberCardContext>
    {
        public MemberCardContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MemberCardContext>();
            optionsBuilder.UseSqlite("Data Source=db/membercard.db");

            return new MemberCardContext(optionsBuilder.Options);
        }
    }
}
