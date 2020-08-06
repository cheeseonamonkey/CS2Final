using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Final
{
    class Inventory
    {
        public int Id
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public double Price
        {
            get;set;
        }

        public Inventory(int id, string nam, double pri)
        {
            Id = id;
            Name = nam;
            Price = pri;
        }

        //gets column names at top of display
        public static string GetInventoryLegend()
            => $" {"Id",-6}{"Name",-23}{"Price",-9}\n-------------------------------------\n";


        public override string ToString()
            => $"#{Id,-6}{Name,-23}{Price,-9:C}";
        
    }
}
