using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FIbonacci
    {
        public static long GetFibRecursively(long n)
        {
            //does a lot of work to simulate processing time lag
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
                return GetFibRecursively(n - 1) + GetFibRecursively(n - 2);
        }
    }

