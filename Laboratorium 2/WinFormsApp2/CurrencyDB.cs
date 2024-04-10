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
        public required string Currency { get; set; }
        public required decimal Value { get; set; }

        public override string ToString()
        {
            return $"{Currency}: {Value}";
        }
    }
}
