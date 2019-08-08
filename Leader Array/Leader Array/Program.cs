using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leader_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //A leader in an array is an element for which all elements on its right side are less than its value. There can be multiple leaders in an array.
           // LeaderArray(); //O(n2);
            LeaderArrayMFR();//O(n);
        }
        public static void LeaderArray()
        {
            //O(n2);
            int[] a = { 15, 16, 3, 2, 6, 4 };
            int n = a.Length, j;
            for (int i = 0; i < n; i++)
            {
                for ( j=i+1; j < n; j++)
                {
                    if (a[j] >= a[i])
                        break;
                }
                if (j == n)
                {
                    Console.Write("{0} \t", a[i]);
                }

            }
            Console.ReadKey();
        }

        public static void LeaderArrayMFR()
        {
            //O(n); Max from Right method
            int[] a = { 15, 16, 3, 2, 6, 4 };
            int n = a.Length ;
            int mfr = a[n - 1];
            Console.Write("{0} \t", mfr);
            for (int k = n-2; k >=0;  k--)
            {
               
                if (a[k]>mfr)
                {
                    Console.Write("{0} \t", a[k]);
                    mfr = a[k];
                }

            }
            Console.ReadKey();
        }
    }
}
