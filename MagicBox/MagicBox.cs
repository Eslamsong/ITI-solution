using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Magic Box Game ");
            Console.WriteLine("Please Enter The Box's Size");

            int size, Total_num, element=1, col, row;

            size=int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Please Enter an odd number");
                size = int.Parse(Console.ReadLine());


            } while (size % 2 == 0);

            Total_num = size * size;
                row = element;
                col = (size + 1) / 2;

                for (element = 1; element <= Total_num; element++)
                {
                    if (element == 1)
                    {
                        
                        Console.WriteLine($" r={row} c={col} num={element}");
                        

                    }

                    else
                    {
                        while (element <= Total_num)
                        {
                            int factor = (element - 1) % size;
                            if (factor == 0)
                            {

                                row = row + 1;
                                col = col;
                                Console.WriteLine($" r={row} c={col} num={element}");
                                

                            }
                            else
                            {
                                row = row - 1;
                                col = col - 1;
                                if (row != 0 && col != 0)
                                {
                                    Console.WriteLine($" r={row} c={col} num={element}");
                                    

                                }
                                else

                                {
                                    if (row == 0)
                                    {
                                        row = size;

                                    }
                                    if (col == 0)
                                    {
                                        col = size;
                                    }
                                    Console.WriteLine($" r={row} c={col} num={element}");
                                    


                                }
                            }

                            element++;  
                        }
                    }


                }
                Console.ReadLine();


            
            
            






        }
    }
}
