using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogorithms
{
    public static class BubbleSort
    {
        public static void BubbleSortAlogo( bool reverse)
        {
            int[] arr = { 5, 3, 1, 6, 7, 2, 4, 8 };
           
            int n = arr.Length;
            Display.displayarray(arr, n);
            for (int p = 0; p < n; p++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (reverse) //reverse
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            Swap.swapnum(arr, i, i + 1);
                        }
                    }
                    else
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            Swap.swapnum(arr, i, i + 1);
                        }

                    }
                }
            }
            Display.displayarray(arr, n);
        }

    }

}
