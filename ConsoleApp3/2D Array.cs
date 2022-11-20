using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr;
            arr = new int[3][];
            arr[0] = new int[4] { 25, 30, 50, 60 };
            arr[1] = new int[4] { 60, 40, 35, 99 };
            arr[2] = new int[4] { 77, 66, 44, 20 };

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int first = 0;
            int second = 0;
            int third = 0, fourth = 0;

            int avg1 = 0, avg2 = 0, avg3 = 0, avg4 = 0;


            for (int i = 0; i < 4; i++)
            {

                sum1 = sum1 + arr[0][i];
                sum2 = sum2 + arr[1][i];
                sum3 = sum3 + arr[2][i];
            }

            Console.WriteLine($"The Total degrees of first student is  {sum1}");
            Console.WriteLine($"The Total degrees of second student is {sum2}");
            Console.WriteLine($"The Total degrees of second student is {sum3}");
            Console.WriteLine();

            
                for(int i = 0; i < 3; i++)
                {
                    first = first + arr[i][0];
                    second = second + arr[i][1];
                    third  = third  + arr[i][2];
                    fourth = fourth + arr[i][3];
                }
                

            
            avg1 = first  /3;
            avg2 = second /3;
            avg3 = third  /3;
            avg4= fourth /3;
            Console.WriteLine($"The Average degrees for the 1st subject is :{avg1}");
            Console.WriteLine($"The Average degrees for the 2nd subject is :{avg2}");
            Console.WriteLine($"The Average degrees for the 3rd subject is :{avg3}");
            Console.WriteLine($"The Average degrees for the 4th subject is :{avg4}");


            Console.ReadLine();


        }
    }
}   
