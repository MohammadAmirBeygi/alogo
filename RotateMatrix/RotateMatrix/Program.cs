using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] squarematrix ={new int [] { 1,2},
                                  new int [] { 3,4} };
            printmatrix(squarematrix);
            Console.ReadKey();
            Rotate(squarematrix);

        }
       public static void printmatrix(int[][] m)
        {
            for (int i = 0; i <m.Length; i++)
            {
                for (int j = 0; j <m.Length; j++)
                {
                    Console.Write("Array={0}\t\t", m[i][j]);
                   
                }
                
                Console.Write("\n");

            }
            
        }

        public static void swap (int i, int j)
        {
            int temp = i;
            i = j;
            j = temp;

        }

        public static void Rotate(int[][] m)
        {
            int last = m.Length - 1;
            int[][] temp ={new int[]{ 1,2},
                           new int[]{ 1,2} };
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                   // temp[i][j] = m[i][j];


                    swap(m[i][i], m[i][last]);
                    swap(m[i][i], m[last][last]);
                    swap(m[i][i], m[last][i]);
                }
            }
            printmatrix(m);
            Console.ReadKey();
        }
    }
}
