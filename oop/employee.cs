using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class employee
    {
        int id;
        string name;
        double salary;



        public employee()
        {
            id = 0;
            salary = 0;
            name = "null";
        }

        public employee(int num, string s, double f)
        {
            id = num;
            name = s;
            salary = f;
        }

        public void Set_id(int num)
        {
            id = num;
        }

        public int get_id()
        {
            return id;
        }
            
        public void set_name(string s)
        {
            name = s;
        }
        public string get_name()
        {
            return name;
        }
        public void set_salary (double f)

        {
            salary = f;
        }
        public double get_salary()
        {
            return salary;  
        }
             


    }
}
