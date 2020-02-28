using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_BFS
{
    class Program
    {
        public static int minimumnumbers(int[] arr,int X, int n)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(X);
            HashSet<int> val = new HashSet<int>();
            int d = 0;
            while(q.Count > 0)
            {
                int s = q.Count();
                while (s-- >0)
                {

                    int c = q.Peek();

                    // Base case 
                    if (c == 0)
                        return d;
                    q.Dequeue();
                    if (val.Contains(c) || c < 0)
                        continue;

                    // Setting current state as visited 
                    val.Add(c);

                    // Pushing the required states in queue 
                    for (int i = 0; i < n; i++)
                        q.Enqueue(c - arr[i]);

                }
                d++;

            }
            // If no possible solution 
            return -1;

        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 4 };
            int n = arr.Length;
            int X = 7;
            Console.WriteLine(minimumnumbers(arr, X, n));
        }
    }
}
