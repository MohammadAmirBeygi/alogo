using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonic
{
    class Program
    {
        static void fibonic(int n)
        {

            int[]a =new int[n];
            a[0] = 0;
            a[1] = 1;
            for (int i=2; i<=n-1; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
                Console.Write(a[i].ToString() + " ");
            }
            Console.ReadKey();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            fibonic(n);

        }
    }
}
