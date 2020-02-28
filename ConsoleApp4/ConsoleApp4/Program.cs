using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class  Program
    {
    //    static void Main(string[] args)
    //    {
    //        //            Reverse words in a given sentence with special characters in place.
    //        // Example: Hello!How’re you?
    //        //Output: olleH!woH’er uoy?
    //        string str=  "Hello!How’re you?",revstr="" ;
    //        int n = str.Length - 1, s = 0;
    //        string temp = "";
    //        string[] tem=  str.Split('!');
    //        char[] ch = tem[0].ToCharArray();
    //        for (int i=ch.Length-1; i>=0; i--)
    //        {
    //            temp += ch[i].ToString();
    //        }
            

    //        //swap(tem, s, tem.Length - 1);

    //        Console.WriteLine(temp);
    //        Console.ReadLine();

           
            

    //        //while ( n>=0)
    //        //{

    //        //    revstr = revstr + str[n];
    //        //    n--;
    //        //}
    //        ////int n = str[0].Length-1, s=0;
    //        ////while (n>s)
    //        ////{
    //        ////    Program.swap(str, s, n);
    //        ////    s++;
    //        ////    n--;
    //        ////}
    //        revstr=string.Join(" ", str.Split('!').Select(x => new string(x.Reverse().ToArray())));
                       
    //            Console.Write(revstr);
           
    //        Console.ReadLine();
            
    //}
        public static void swap( string[] str,int s, int n)
        {
            string temp = "";

            temp = str[s];
            str[s] = str[n];
            str[n] = temp;
           
        }
    }
}
