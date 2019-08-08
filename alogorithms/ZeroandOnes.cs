using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogorithms
{
    public static class ZeroandOnes
    {
       public static void segregate0sand1s()
        {
            int[] ar = { 0, 1, 1, 0, 1, 0, 0, 1 };

            int n = ar.Length;
            int count = 0;
            Display.displayarray(ar, n);
            for (int p = 0; p < n; p++)
            {
                if (ar[p] == 0) count++;

            }
            for (int i = 0; i < n; i++)
            {
                if (i <count)
                    ar[i] = 0;
                else
                    ar[i] = 1;
            }
            Display.displayarray(ar, n);
        }

    }
}
