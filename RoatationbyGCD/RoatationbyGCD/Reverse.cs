using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoatationbyGCD
{
    public static class Reverse
    {
        public static void swap (string[] a, int s, int e)
        {
            string temp = "";
            
            temp = a[s];
            a[s] = a[e];
            a[e] = temp;
          
        }

        public static void Test ()
        {
            string[] a = { "a", "b", "c", "d", "e", "f", "g" };
            int n = a.Length;
            int s = 0, e = n - 1;
            while (s<e)
            {
                swap(a,s,e);
                s = s + 1;
                e = e - 1;

            }
            Program.displaystringarray(a, n);
        }
    }
}
