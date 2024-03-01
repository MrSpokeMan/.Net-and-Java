using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number as a upper bound: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //FizzBuzz run = new FizzBuzz(num);
            //run.Function();
            FizzBuzz.Function(num);
        }
    }
}
