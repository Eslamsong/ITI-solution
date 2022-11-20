using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee emp1 = new Employee(1353, "Jack", 39532.5);
            Customer c = new Customer(8006445, 25, "Mark");
            Person p = emp1;
            p.print_data();

             p = c;
            p.print_data();

            Console.ReadLine();

        }
    }

}
