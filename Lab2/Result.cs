using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Result
    {
        public List<int> items;
        public int value;
        public int weight;

        public Result(List<int> items, int value, int weight)
        {
            this.items = items;
            this.weight = weight;
            this.value = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Items: ");
            for (int i = 0; i < items.Count(); i++)
            {
                sb.AppendLine("Item " + items[i]);
            }
            sb.AppendLine("Total value: " + value);
            sb.AppendLine("Total weight: " + weight);
            return sb.ToString();
        }
    }
}
