using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ReverseSTACK
    {
        // reverses individual words  
        // of a string  
        public static void reverseWords(string str)
        {
            Stack<char> st = new Stack<char>();
            // Traverse given string and push  
            // all characters to stack until 
            // we see a space.  
            for (int i = 0; i < str.Length; i++)
            {
                    if (str[i]!= ' ')
                    {
                         st.Push(str[i]);
                    }
                // When we see a space, we  
                // print contents of stack.  
                else
                {
                   while(st.Count>0)
                    {
                        Console.Write(st.Pop());
                    }
                    Console.Write(" ");
                }
            }
            // Since there may not be  
            // space after last word.  
            while (st.Count > 0)
            {
                Console.Write(st.Pop());

            }
            Console.ReadKey();
           
        }
        // Driver Code 
        //public static void Main(string[] args)
        //{
        //    string str = "Geeks for Geeks";
        //    reverseWords(str);
        //}

    }
}
