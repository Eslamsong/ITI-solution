﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr;
            arr = new int[3][];

            int x, y, z;
            Console.WriteLine("Enter num of subjects of the 1st student");
            x=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num of subjects of the 2nd  student");
             y=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num of subjects of the 3rd student");
             z=int.Parse(Console.ReadLine());

            arr[0] = new int[x];
            arr[1] = new int[y];
            arr[2] = new int[z];

             
            for (int i = 0; i < 3; i++)

            {
                if(i== 0) 
                {

                    Console.WriteLine("Enter The degree of each subject of student no 1 ");
                    for (int j = 0; j < x; j++)
                    {
                        arr[i][j] = int.Parse(Console.ReadLine());

                    }
                }

                if (i == 1) 

                {

                    Console.WriteLine("Enter The degree of each subject of student no 2 ");
                    for (int k = 0; k < y; k++)
                    {
                        arr[i][k] = int.Parse(Console.ReadLine());
                    }
                }

                if(i == 2) 
                {
                    Console.WriteLine("Enter The degree of each subject of student no 3 ");
                    for (int w = 0; w < z; w++)
                    {
                        arr[i][w] = int.Parse(Console.ReadLine());

                    }
                }                
                
            }

            int sum1 = 0, sum2 = 0,sum3 = 0;

            for (int i = 0; i < 3; i++)
            {

                if (i == 0)
                {
 
                    for (int j = 0; j < x; j++)
                    {
                        sum1=sum1 + arr[i][j];

                    }
                }

                if (i == 1)

                {

                    for (int k = 0; k < y; k++)
                    {
                        sum2 = sum2 + arr[i][k];
                    }
                }

                if (i == 2)
                {
                    for (int w = 0; w < z; w++)
                    {
                        sum3 = sum3 + arr[i][w];

                    }
                }


            }

            Console.WriteLine($"The Total degrees of first student is  {sum1}");
            Console.WriteLine($"The Total degrees of second student is {sum2}");
            Console.WriteLine($"The Total degrees of second student is {sum3}");

            Console.ReadLine();


        }
    }
}
