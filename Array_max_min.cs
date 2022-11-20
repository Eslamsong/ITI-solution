using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr;
            arr = new int[5];
            Console.WriteLine("Enter Five numbers");
            
            for(int i= 0; i < 5; i++)
            {

                arr[i] =int.Parse(Console.ReadLine());

            }
            int max = arr[0];
            
            int min = 0;
            int sum = 0;
            int max_arr1 = 0;
            int max_arr2 = 0;
            double avg;
            for (int i = 1; i < 5; i++)
            {
                if(arr[i] > max)
                {
                    max= arr[i];
                    max_arr1 = i+1;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    max_arr2 = i+1;
                }

              
            }
            Console.WriteLine($"The Index of the max value is {max_arr1}");
            Console.WriteLine($"The Index of the min value is {max_arr2}");

            for (int i = 0; i < 5; i++)
            {
                sum= sum + arr[i];
                
            }
            avg = sum / 5;
            Console.WriteLine($"the average of the five numbers is {avg}");
            Console.ReadLine();
        }
    }
}
