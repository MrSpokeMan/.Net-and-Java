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
            var currency1 = new CurrencyDB() { Id = 1, Timestamp = 1631539200 };
            currency1.Rates.Add("USD", 1.0m);
            var currency2 = new CurrencyDB() { Id = 2, Timestamp = 1631539200 };
            currency2.Rates.Add("EUR", 0.85m);
            var currency3 = new CurrencyDB() { Id = 3, Timestamp = 1631539200 };
            currency3.Rates.Add("JPY", 110.0m);
            modelBuilder.Entity<CurrencyDB>().HasData(
                    currency1, currency2, currency3
            );
        }   
    }
}