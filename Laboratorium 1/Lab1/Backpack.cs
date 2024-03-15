using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTestProject1"), InternalsVisibleTo("WinFormsApp1")]

namespace Lab1
{
    internal class Backpack
    {
        struct Item
        {
            public int weight;
            public int value;
            public bool fit; // 0 - no, 1 - yes
            public int number;
        }

        private int itemsCount;
        private List<Item> items;
        private int counter = 0;

        public Backpack(int itemsCount, int seed, bool given=false)
        {
            this.itemsCount = itemsCount;
            this.items = new List<Item>();
            Random rand = new Random(seed);
            if (!given)
            {
                for (int i = 0; i < this.itemsCount; i++)
                {
                    Item item = new Item();
                    item.weight = rand.Next(1, 10);
                    item.value = rand.Next(1, 10);
                    item.fit = false;
                    item.number = i + 1;
                    items.Add(item);
                }
            }
        }

        public void AddItem(int weight, int value)
        {
            Item item = new Item();
            item.weight = weight;
            item.value = value;
            this.counter++;
            item.number = this.counter;
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Number of items: " + itemsCount);
            sb.AppendLine("Items: ");
            for (int i = 0; i < itemsCount; i++)
            {
                sb.AppendLine("Item " + items[i].number + ": weight = " + items[i].weight + ", value = " + items[i].value);
            }
            return sb.ToString();
        }

        public Result Solve(int capacity)
        {
            items = items.OrderByDescending(item => (double)item.value / item.weight).ToList();

            List<int> selectedItems = new List<int>();
            int totalValue = 0;
            int totalWeight = 0;

            foreach (var item in items)
            {
                if (totalWeight + item.weight <= capacity)
                {
                    selectedItems.Add(item.number);
                    totalValue += item.value;
                    totalWeight += item.weight;
                    // item.fit = true; //DOPYTAĆ JAK TO OBEJŚĆ
                }
                else
                {
                    break;
                }
            }

            Result result = new Result(selectedItems, totalValue, totalWeight);
            return result;
        }
    }
}
