using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursion
{
    internal class Program
    {
        static int fact(int x)
        {
            int result=1;
            if(x==1)
            {
                return 1;
            }

            if(x>1)
            {

                result = x * fact(x - 1);

            }
            return result;



        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter  a number");

             int num;
             num = int.Parse(Console.ReadLine());

             int factorial;

             factorial = fact(num);
             Console.WriteLine($"the Factorial is {factorial}");

             Console.ReadLine();

             */

            Console.WriteLine("Enter  a number");

            int num;
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The factorial using loops");

            int outcome = 1;
            for(int i= num; i>1; --i)
            {

                outcome =  outcome* i;
            }
            Console.WriteLine($"the Factorial is {outcome}");
            Console.ReadLine();



        }

    }
}
