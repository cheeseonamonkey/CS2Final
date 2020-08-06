using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Final
{
    class Invoice
    {
        public int Id
        {
            get; set;
        }
        public int CustomerId
        {
            set; get;
        }
        public Date Date
        {
            get;set;
        }

        public Invoice(int id, int custid, int m, int d, int y)
        {
            Id = id;
            CustomerId = custid;
            Date = new Date(m,d,y);
        }

    }
}
