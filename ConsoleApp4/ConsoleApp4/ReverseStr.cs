using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ReverseStr
    {
        public static void Reversestring(char[] arr)
        {
            int rptr = arr.Length - 1 ,l = 0;

            while(l<rptr)
            {
                if(!char.IsLetter(arr[l]))
                {
                    l++;

                }

               else if (!char.IsLetter(arr[rptr]))
                {
                    rptr--;

                }
                else
                {
                    char temp = arr[rptr];
                    arr[rptr] = arr[l];
                    arr[l] = temp;
                    l++;
                    rptr--;
                }

            }
        }

        //static void Main(string[] args)
        //{
        //    string str = "Hello!How’re you?";
        //    char[] chr = str.ToCharArray();
        //    Console.WriteLine("Input String:" + str);
        //    Reversestring(chr);
        //    string rstr = new string(chr);
        //    Console.WriteLine("Output String:" + rstr);
        //    Console.ReadLine();
        //}
    }
    
}