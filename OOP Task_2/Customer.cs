using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_2
{
    internal class Customer:Person
    {
        int account_no;

        public Customer()
        {
            account_no = 0;
        }
        public Customer(int AN,int i,string s):base(i,s)
        {
            account_no = AN;
        }

        public void set_acc_num(int AN)
        {
            this.account_no = AN;
        }
        public int get_acc_num()
        {
            return account_no;
        }
        public override void print_data()
        {
            Console.WriteLine($"Customer Bank account is {account_no}  and  the Name is {name}  the ID is {id}");
        }
    }
}
