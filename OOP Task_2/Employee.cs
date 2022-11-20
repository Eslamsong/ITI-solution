using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_2
{
    internal class Employee : Person
    {
        double salary;

       public Employee()
        {
            salary=0;
        }

        public Employee (int i, string s,double m ) :base( i, s)
        {
            salary=m;
        }

        public void set_salary(double m)
        {
            salary = m;
            
        }
        
        public double get_salary()
        {
            return salary;
        }

        public override void print_data()
        {
            Console.WriteLine($"Emplyee ID is {id} Emplyee salary is {salary} and the name is {name}");
        }
    }

}
