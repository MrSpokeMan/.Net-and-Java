using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int itemsCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Backpack backpack = new Backpack(itemsCount, seed);

            Console.WriteLine("Enter the capacity of the backpack: ");
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(backpack);

            Console.WriteLine(backpack.Solve(capacity));
        }
    }
}
