using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alogorithms
{
    public static class BinarySearch
    {
        public static void BinarySearchResult()
        {
            int[] arr = { 2, 5, 7, 11, 12, 15, 20, 30, 34, 36 };
          
            int SE = 34;
            
        

        }
        public  static int BinarySearchalgo( int[] arr, int SE)
            {
            int n = arr.Length;
            int s = 0, m = 0, i = 0;
            int E = n - 1;
            m = s + E / 2;
            while (i < n)
            {
                m = (s + E )/ 2;
                if (arr[m] == SE) return m;
                else if (SE < arr[m])
                {
                    E = m - 1;

                }
                else
                {
                    s = m + 1;
                    E = n - 1;
                }
                i++;
            }
         
             return m;
            
           }
    }
}
