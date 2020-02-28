using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ReverseEachword
    {
        static String reverseWords(String str)
        {

            // Pointer to the first character  
            // of the first word  
            int start = 0;
            for (int i = 0; i < str.Length; i++)
            {

                // If the current word has ended  
                if (str[i] == ' ' ||
                        i == str.Length - 1)
                {

                    // Pointer to the last character  
                    // of the current word  
                    int end;
                    if (i == str.Length - 1)
                        end = i;
                    else
                        end = i - 1;

                    // Reverse the current word  
                    while (start < end)
                    {
                        if (!char.IsLetter(str[start]))
                        {
                            start++;

                        }

                        else if (!char.IsLetter(str[end]))
                        {
                            end--;

                        }
                        //else
                        {
                            str = swap(str, start, end);
                            start++;
                            end--;
                        }
                    }

                    // Pointer to the first character  
                    // of the next word  
                    start = i + 1;
                }
            }

            return str;
        }

        static String swap(String str, int i, int j)
        {
            char[] ch = str.ToCharArray();
           

                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
            
                return String.Join("", ch);
            
        }
        //static void Main(string[] args)
        //{
        //    string str = "Hello! How're you?";

        //    Console.WriteLine("Input String:" + str);
        //    reverseWords(str);
        //    Console.WriteLine(reverseWords(str));
        //    Console.ReadLine();
        //}
    }
}
