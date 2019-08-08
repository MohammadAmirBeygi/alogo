using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogorithms
{
    static class Display
    {
        public static void displayarray(int[] a, int n)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} \t", a[i]);
                
            }
            Console.Write("\n");
            Console.ReadKey();
        }
        public static void displaystringarray(string[] a)
        {
            int i;
            for (i = 0; i < a.Length-1; i++)
            {
                Console.Write("{0} \t", a[i]);

            }
            Console.Write("\n");
            Console.ReadKey();
        }
        public static void displaycustomarray(int[] a, int index, string val)
        {
            int i;
            Console.Write("Given Array =");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("{0} \t", a[i]);

            }

            Console.Write("\n");
            Console.Write(val + "=" + "{0}", index.ToString());
            Console.Write("\n");
            Console.Write(val+ "=" + "{0}", a[index]);
            Console.ReadKey();
        }
    }
}
