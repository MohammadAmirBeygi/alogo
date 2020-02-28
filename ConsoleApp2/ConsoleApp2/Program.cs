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

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        float p = 0, n = 0, z = 0;
        foreach (int v in arr)
        {
            if (v > 0)
            {
                p++;
            }
            else if (v < 0) { n++; }
            else if (v == 0) { z++; }

        }
        Console.WriteLine((p / 6).ToString());
        Console.WriteLine((n / 6).ToString());
        Console.WriteLine((z / 6).ToString());
        Console.ReadLine();
    }
    static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        //int[] arr = { -4, 3, -9, 0, 4, 1 };
        //plusMinus(arr);
        int[] ar = { 10,9,12,3,4,15,1};
        Findmax(ar);
    }

    static void Findmax (int[] ar)
    {
        int max = ar[0];
      
        foreach (int v in ar)
        {
            if (v > max)
            {
                max = v;
            }
           

        }
        Console.WriteLine(" the maxvalue is :{0}",max.ToString());
        
        Console.ReadLine();
    }


    static void InsertSorting(int[] ar)
    {
        int max = ar[0];

        foreach (int v in ar)
        {
            if (v > max)
            {
                max = v;
            }


        }
        Console.WriteLine(" the maxvalue is :{0}", max.ToString());

        Console.ReadLine();
    }
    //static void Main()
    //{
    //    // Declare the array of two elements:
    //    int[][] arr = new int[2][];

    //    // Initialize the elements:
    //    arr[0] = new int[5] { 1, 3, 5, 7, 9 };
    //    arr[1] = new int[4] { 2, 4, 6, 8 };

    //    // Display the array elements:
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        System.Console.Write("Element({0}): ", i);

    //        for (int j = 0; j < arr[i].Length; j++)
    //        {
    //            System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
    //        }
    //        System.Console.WriteLine();
    //    }
    //    // Keep the console window open in debug mode.
    //    System.Console.WriteLine("Press any key to exit.");
    //    System.Console.ReadKey();
    //}

}
