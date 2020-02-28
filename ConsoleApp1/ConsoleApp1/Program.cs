using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) {
int d1=0,d2=0;
     
for (int i=0; i<=arr.Length-1; i++)
{
    for (int j=0;j<=arr[i].Length-1; j++)
     {
                //if((arr[i][j] ==arr[0][0])|| (arr[i][j] ==arr[1][1])||(arr[i][j] ==arr[2][2]))

                //{
                //    d1+=arr[i][j];

                //}
                //else if((arr[i][j] ==arr[0][2])|| (arr[i][j] ==arr[1][1])||(arr[i][j] ==arr[2][0]))

                //{
                //    d2+=arr[i][j];

                //}
                if (i==j)

                {
                    d1 += arr[i][j];

                }
            //    if ((i== 0 && j==2) || (i == 1 && j == 1) || (i == 2 && j == 0))
            
                
                    if (i == (arr.Length - 1) - j)
                    {
                    d2 += arr[i][j];

                }



            }


        }
        return d2-d1;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[][] arr = new int[n][];

        //for (int i = 0; i < n; i++) {
        //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //}
       // int[][] arr = new int[3][3] { { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } } };


        int[][] arr = new int[4][];

        arr[0] = new int[3] { 11, 2, 4 };

        arr[1] = new int[3] { 4, 5,6 };
        arr[2] = new int[3] { 10, 8, -12 };
        arr[3] = new int[3] { 9, 1, 2 };

        int result = diagonalDifference(arr);
        Console.WriteLine(result.ToString());

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
