﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        public static void swap(ref int x,ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y=temp;

            Console.WriteLine("After Swap");
            Console.WriteLine($"The first value is {x}");
            Console.WriteLine($"The second value is {y}");
            Console.ReadLine();

        }

       public static void Main(string[] args)
        {

            Console.WriteLine("Enter the first value");
            int num1, num2;

            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            num2 = int.Parse(Console.ReadLine());

            swap(ref num1, ref num2);



        }
    }
}
