using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Join_Method
{
    class JoinThread
    {
        static void Thread1()
        {
            Console.WriteLine("Thread1 starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread1 is Executed" + i);
            }
            Console.WriteLine("Thread1 exiting the run");
        }
        static void Thread2()
        {
            Console.WriteLine("Thread2 Starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread2 is started " + i);
            }
        }
        static void Thread3()
        {
            Console.WriteLine("Thread3 Starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread3 is exiting " + i);
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration on Join method in MultiThreading");

            Console.WriteLine("Main Thread Started");

            //binded the method with the method objectVV
            Thread T1 = new Thread(Thread1);
            Thread T2 = new Thread(Thread2);
            Thread T3 = new Thread(Thread3);
            //start the thread - run the method
            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            Console.WriteLine("Main Thread is Exiting");
            Console.ReadLine();
        }
    }
}