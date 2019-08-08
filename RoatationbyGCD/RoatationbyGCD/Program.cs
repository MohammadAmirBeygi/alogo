using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoatationbyGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int n = a.Length;
            int k = 2;
            string [] b = { "a","b","c","d","e","f","g"};
            int num = b.Length;
            int r = 2;

            //  rotatearray(a, n, k); // GCD algorithm to rotate
            //  rotatearrayBYK(a, n, k);
            //displayarray(a, n);
          //  ReverseRotate(b, num, r); // Reverseal algorithm to rotate

            Reverse.Test();
        }
        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
             return GCD(b, a % b);
        }
       public static void rotatearray(int[] a, int n, int k)
        {
          int d=1,i,j,temp;
            for (i=0; i<GCD(n,k); i++)
            {
                j = i;
                temp = a[i];
                while(true)
                {
                    d = (j + k) % n;
                    if (d == i) break;
                    a[j] = a[d];
                    j = d;
                }
                a[j] = temp;
            }
        }

        public static void rotatearrayBYK(int[] a, int n, int k)
        {
            int[] b =new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                b[(i + k) % n] = a[i];
               
            }
            displayarray(b, n);
        }
        public static void ReverseRotate(string[] a, int n, int r)
        {
            Array.Reverse(a, 0, n-r);
            Reverse.swap(a, n-r, n);
           //Array.Reverse(a, n-r, r);
            Array.Reverse(a, 0, n);

        }
        public static void  displayarray(int[]a,int n)
        {
            int i;
            for (i=0;i<n; i++)
            {
                Console.Write("{0} \t", a[i]);
                Console.Write("\n");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        public static void displaystringarray(string[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} \t", a[i]);
                Console.Write("\n");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
