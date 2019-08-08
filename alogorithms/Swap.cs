using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogorithms
{
    public static class Swap
    {
        public static void swapnum (int[] a, int s, int e)
        {
            int temp = 0;

            temp = a[s];
            a[s] = a[e];
            a[e] = temp;

        }
    }
}
