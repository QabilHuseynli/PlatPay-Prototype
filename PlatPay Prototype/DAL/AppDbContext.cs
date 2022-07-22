
using Microsoft.EntityFrameworkCore;
using PlatPay_Prototype.DAL.Configuration;
using PlatPay_Prototype.Models;

namespace PlatPay_Prototype.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(
                @"Host=localhost;Username=postgres;Password=123456;Database=Platv5;Pooling=true;");

            //optionsBuilder.UseSqlite("Data Source=PlatPayDbV4.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankCardConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BankCard> BankCards { get; set; }
        public DbSet<Edv> Edvs { get; set; }
    }
}
