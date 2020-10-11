using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PRIORITIES
{
    class threadpriority
    {
        static long count1, count2;

        public static void incrementcount1()

        {
            while (true)//indefinite loop
                count1 += 1;
            //Console.WriteLine("Thread 1 started");
        }
        public static void incrementcount2()
        {
            while (true)//indefinite loop
                count2 += 1;
            //Console.WriteLine("Thread 2 started");
        }


        static void Main(string[] args)
        {
            Thread T1 = new Thread(incrementcount1);//invoke method incrementcount1
            Thread T2 = new Thread(incrementcount2);//invoke method incrementcount2
            Console.WriteLine("Main thread is going to sleep for 55 seconds");
            Thread.Sleep(5000);
            Console.WriteLine("main method wakesup");
            T1.Priority = ThreadPriority.AboveNormal;
            T2.Priority = ThreadPriority.BelowNormal;

            T1.Start(); T2.Start();
            T1.Abort(); T2.Abort();
            T1.Join(); T2.Join();
            Console.WriteLine("count 1 is AboveNormal: " + count1);
            Console.WriteLine("count 2 is BelowNormal: " + count2);
            Console.ReadLine();

        }
    }

}
