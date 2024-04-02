using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class CurrencyDB
    {
        public int Id { get; set; }
        public string? Disclaimer { get; set; }
        public string? License { get; set; }
        public required long Timestamp { get; set; }
        public string? Base { get; set; }

        [NotMapped]
        public Dictionary<string, decimal> Rates { get; set; }

        public CurrencyDB()
        {
            Rates = new Dictionary<string, decimal>();
        }

        public override string ToString()
        {
            return $"{Id} {Rates.Keys}: {Rates.Values}";
        }
    }
}
