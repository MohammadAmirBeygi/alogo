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

//public class SquareMatrix
//{


//    public static void Main(String[] args)
//    {


//        int[][] squarematrix ={new int [] { 1,1,1,10},
//                                new int [] { 1,10,-1,2},
//                                new int [] { 1,-2,1,2},
//                                new int [] {1,1,1,-2}};


//        int primryDiagonaSum = 0, secondaryDiagonalSum = 0;


//        int size = squarematrix.Length - 1;


//        for (int i = 0; i < squarematrix.Length; i++)
//        {


//            primryDiagonaSum += squarematrix[i][i];


//            secondaryDiagonalSum += squarematrix[i][size - i];


//        }


//        Console.WriteLine(" Primary diagonal sum =" + primryDiagonaSum);


//        Console.WriteLine(" Secondary diagonal sum =" + secondaryDiagonalSum);


//    }


//}

// Stair Case Patterns


class GFG
{

    // Function definition
    static void pattern(int n)
    {
        // for loop for rows
        //for (int i = 1; i <= n; i++)
        //{

        //    // conditional operator
        //    int k;

        //    if (i % 2 != 0)
        //        k = i + 1;
        //    else
        //        k = i;

        //    // for loop for 
        //    // printing spaces
        //    for (int g = n; g > k; g--)
        //        Console.Write(" ");

        //    // according to value of 
        //    // k carry out further 
        //    // operation
        //    for (int j = 0; j < k; j++)
        //        Console.Write("* ");
        //    Console.WriteLine();


        //}
         for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <i; j++)
            {
                Console.Write("*");

            }
            //for (int j = 0; j < i; j++)
            //{
            //    Console.Write(" ");

            //}
            Console.WriteLine();
    }
    Console.ReadLine();
    }

    // Driver code
    public static void Main()
    {
        int n = 9;
        pattern(n);
    }
}