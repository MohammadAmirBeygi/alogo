using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MultiplyAraay
    {
        static int[] arr = { 1, 2, 3, 4, 5, 6 };

        static int  mul( int[]a, int n)
        {
            int val = 1;
            int[] temp;
            for (int i=0; i<=n; i++)
            {
                //Array.Copy(temp,a, n);
              // val=  MultiAraay(a, n);
              for (int j=0; j<=n; j++)
                {
                    if (i != j)
                        val = val * a[j];

                }
                Console.WriteLine(val);
                Console.WriteLine();
                val = 1;
            }
            return val;
        }
        static int MultiAraay(int[]a,int n)
        {
            if (n == 0)
            {
                return (a[n]);
            }
            else
            { 
               
                    return (a[n] * MultiAraay(a, n - 1));
               
            }

        }
        //static void Main(string[] args)
        //{
        //    // Console.WriteLine(MultiAraay(arr, arr.Length - 1));
        //   mul(arr, arr.Length - 1);
        //    Console.ReadKey();
        //}
    }
}
