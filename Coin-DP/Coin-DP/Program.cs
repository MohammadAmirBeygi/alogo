using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2, 3, 4 };
            int x = 5;
            for (int i=0; i<5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 0) { a[i] = 1; }

                }
            }
    }
}
