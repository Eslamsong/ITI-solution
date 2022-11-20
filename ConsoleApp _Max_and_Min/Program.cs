using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_num;
            int max, min,num;
            Console.WriteLine("Enter The total numbers");
            total_num=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The first number");
            max=int.Parse(Console.ReadLine());
            min = max;

            for(int i=1; i<total_num; i++)
            {
                Console.WriteLine("Enter the next number");
                num=int.Parse(Console.ReadLine());  
                if(num>max)
                {
                    max=num;
                }
                if (num < min)
                {
                    min = num;
                }

            }

            Console.WriteLine($"The Maximum Value is: {max}");
            Console.WriteLine($"The Minimum Value is: {min}");
            Console.ReadLine();










        }
    }
}
