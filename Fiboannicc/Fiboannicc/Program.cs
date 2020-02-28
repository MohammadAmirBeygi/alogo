using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiboannicc
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 0, n2 = 1, n3, limit=10;
            //Console.WriteLine("Fibonacci series:");
            //Console.Write(n1 + " " + n2 + " ");

            //for (int i=0; i<=10; i++)
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //    n1 = n2; n2 = n3;

            //}
            //Console.ReadLine();

            int n, i = 0, c;
            Console.WriteLine("Enter the number of terms:");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fibonacci series\n");

            for (c = 1; c <= n; c++)
            {
                int result =Program.fiban(i);
                Console.Write(result + " ");
                i++;
            }
            Console.WriteLine();
            Console.ReadLine();
           // return 0;
        }
        public  static int  fiban(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (fiban(n - 1) + fiban(n - 2));
            }
        }

    }
}
