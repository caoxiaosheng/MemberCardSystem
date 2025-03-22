using MemberCardSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberCardSystem
{
    public class MemberCardContext:DbContext
    {
        public MemberCardContext() : base()
        {

        }

        public MemberCardContext(DbContextOptions<MemberCardContext> options):base(options)
        {
            
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<BuyRecord> BuyRecords { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<OldShoes> OldShoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db/membercard.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyRecord>().HasIndex(x => x.CardId);
            modelBuilder.Entity<OldShoes>().HasIndex(x => x.CardId);
        }
    }
}
