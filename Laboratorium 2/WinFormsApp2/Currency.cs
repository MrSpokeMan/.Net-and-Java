using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Currency
    {
        public string? Disclaimer { get; set; }
        public string? License { get; set; }
        public required long Timestamp { get; set; }
        public string? Base { get; set; }
        public required Dictionary<string, decimal>  Rates { get; set; }

        public Currency()
        {
            Rates = new Dictionary<string, decimal>();
        }

        public override string ToString()
        {
            return $"{Disclaimer} {License} {Timestamp} {Base} {Rates.Keys}: {Rates.Values}";
        }
    }
}
