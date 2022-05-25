using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void Greet();
    class Program
    {
       public static void Wish()
        {
            Console.WriteLine("Good Morning....from wish method");
        }
        static void Main(string[] args)
        {
            Greet greetobject;
            greetobject = new Greet(Wish);
            Program1 p = new Program1();
            greetobject= greetobject + p.Hello;
            greetobject();
            Console.ReadKey();
        }
    }
    class Program1
    {
        public void Hello()
        {
            Console.WriteLine("Hello!....from hello method");
        }
    }
}


