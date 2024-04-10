using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class ExchangeStock : DbContext
    {
        public DbSet<CurrencyDB> CurrencyDB { get; set; }
        public ExchangeStock()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Currency.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var currency1 = new CurrencyDB() { Id = 1, Currency = "PKB", Value = 2.1m };
            var currency2 = new CurrencyDB() { Id = 2, Currency = "UGG", Value = 100000.0m };
            modelBuilder.Entity<CurrencyDB>().HasData(
                    currency1, currency2
            );
        }

        public bool IsEmpty()
        {
            if (CurrencyDB.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}