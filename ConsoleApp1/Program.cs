using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            



            double a, b, c ,x1,x2;
            Console.WriteLine("Enter the first factor A ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second factor B ");
            b = double.Parse(Console.ReadLine());

          
            Console.WriteLine("Enter the third factor C ");
            c = double.Parse(Console.ReadLine());


            double factor = (b * b) - (4 * a * c);

            if(factor < 0)
            {
                x2 = (-b / 2*a);
                x1 = (-b / 2*a);
                Console.WriteLine($" The Value of is  x1 is {x1}+img ");
                Console.WriteLine($" The Value of is  x2 is {x2}-img ");
                Console.ReadLine();
            }
             else
                if(factor > 0)
                {
                double temp = Math.Sqrt(factor);
                 x1 =(-b+ (Math.Sqrt(factor)))/ (2*a);
                 x2= (-b -(Math.Sqrt(factor))) / (2*a);

                Console.WriteLine($" The Value of is  x1 is {x1}");
                Console.WriteLine($" The Value of is  x2 is {x2}");
                Console.ReadLine();
                }
                else
                   if (factor == 0)
                    {
                       x1 = x2=(-b/2*a);
                      Console.WriteLine($" The Value of is  x1 is {x1} ");
                      Console.WriteLine($" The Value of is  x2 is {x2} ");
                      Console.ReadLine();

                    }
                   
               

                
















        }
    }
}
