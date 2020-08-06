using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Final
{
    class Customer
    {
        public int Id
        {
            get;set;
        }
        public string First
        {
            get;set;
        }
        public string Last
        {
            get;set;
        }

        public string Name
        {
            get => $"{Last}, {First}";
        }

        public Customer(int custid, string f, string l)
        {
            Id = custid;
            First = f;
            Last = l;
        }


        //gets column names at top of display
        public static string GetCustomerLegend()
            => $" {"ID",-6}{"Name",-20}\n-------------------------------------\n";


        public override string ToString()
            => $"#{Id,-6}{Name,-20}";
        
    }
}
