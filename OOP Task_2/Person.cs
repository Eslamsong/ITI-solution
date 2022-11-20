using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_2
{
     internal abstract class Person
    {
        protected int id;
        protected string name;

        public Person() 
        {
            id = 0;
            name = "null";
        }
        public Person(int i,string s)
        {
            id = i; 
            name = s;
        }
        public void set_id( int i)
        {
            this.id = i;
        }

        public void set_name(string s)
        {
            name = s;
        }
        public int get_id()
        {
            return id;
        }
        public string get_name()
        {
            return name;    
        }
        public abstract void print_data();
    
    }
}
