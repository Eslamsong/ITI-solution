﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PowerRecursion
{
    internal class Program
    {
      
        static int Get_power(int x,int y)
        {
            int result=1;
            if (y == 0)
            {
                return result;
            }
            if(y>0)
            {
                result =  x* Get_power(x,(y-1));


                

            }
            return result;


        }
        static void Main(string[] args)
        {

            int outcome;
            Console.WriteLine("Please Enter the base number");
            int basee;
            basee=int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the power number");
            int power;
            power = int.Parse(Console.ReadLine());

            outcome =Get_power(basee, power);
            Console.WriteLine($"the result is {outcome}");
            Console.ReadLine();









        }
    }
}
