using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        public static void fill_data(employee e)
        {
            e.set_name("Ahmed");
            e.set_salary(1598.54);
            e.Set_id(100);
        }
        public static void print_data(employee emp)
        {
            Console.WriteLine($"The Employee salary is :{emp.get_salary()}" );
            Console.WriteLine($"The Employee ID is :{emp.get_id()}");
            Console.WriteLine($"The Employee name is :{emp.get_name()}");


        }

        static void Main(string[] args)
        {
            employee emp = new employee(500,"mohammed",4695.40);
            fill_data(emp);
            print_data(emp);
            Console.ReadLine();

            
        }
    }
}
