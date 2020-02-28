using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //public interface text
    //{
    //    void print();
    //}
    //class format : text
    //{
    //    public void print()
    //    {
    //        Console.WriteLine(" here is text format");
    //    }
    //}
    //// constructor injection
    //public class constructorinjection
    //{
    //    private text _text;
    //    public constructorinjection(text t1)
    //    {
    //        this._text = t1;
    //    }
    //    public void print()
    //    {
    //        _text.print();
    //    }
    //}

    public interface Iset
    {
        void print();
    }
    public class service : Iset
    {
        public void print()
        {
            Console.WriteLine("print........");
        }
    }
    public class client
    {
        private Iset _set;
        public void run(Iset serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //constructorinjection cij = new constructorinjection(new format());
            //    cij.print();
            //Console.ReadKey();

            client cn = new client();
            cn.run(new service());
            Console.ReadKey();
        }
    }
}
