﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class FizzBuzz
    {
        public FizzBuzz() { }
        public void Function()
        {
            Console.WriteLine("Enter a number as a upper bound: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if(i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0) Console.WriteLine("Fizz");
                else if(i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
