using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lockmethod
{
    class program
    {
        public void Display()
        {
            lock (this)
            {


                Console.WriteLine("Csharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented programming language");


            }
        }
        
        static void Main(string[] args)
        {
                program obj = new program();
            //instaticated the thread with method interface
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        
    }
}
