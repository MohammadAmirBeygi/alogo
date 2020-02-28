using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StacKReverse
    {

        // using Stack class for  
        // stack implementation  
        static Stack st = new Stack();
        // Below is a recursive function  
        // that inserts an element  
        // at the bottom of a stack.  
        static void insert_at_bottom(char x)
        {
            if (st.Count == 0)
                st.Push(x);
            else
            {

                // All items are held in Function  
                // Call Stack until we reach end  
                // of the stack. When the stack becomes  
                // empty, the st.size() becomes 0, the  
                // above if part is executed and  
                // the item is inserted at the bottom  

                char a = (char)st.Peek();
                st.Pop();
                insert_at_bottom(x);
                // push allthe items held  
                // in Function Call Stack  
                // once the item is inserted  
                // at the bottom  
                st.Push(a);
            }
        }


        // Below is the function that  
        // reverses the given stack using  
        // insert_at_bottom()  
        static void reverse()
        {
            if (st.Count > 0)
            {
                // Hold all items in Function  
                // Call Stack until we  
                // reach end of the stack  
                char x = (char)st.Peek();
                st.Pop();
                reverse();
                insert_at_bottom(x);

            }
        }
        public static void Main(String[]args)
        {
            st.Push('1');
            st.Push('2');
            st.Push('3');
            st.Push('4');

            Console.WriteLine("Original Stack");

            foreach(char i in st)
            {
                Console.WriteLine(i);
            }
            // function to reverse  
            // the stack  
            reverse();
            foreach (char i in st)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
