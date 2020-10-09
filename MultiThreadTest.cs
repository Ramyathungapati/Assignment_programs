using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadTest
{
	class MultiThreading
	{
		static void Thread1()
		{
			for(int i =1;i<15;i++)
			{
				Console.WriteLine("Thread 1 is started at the position : " + i);
			}
		}
		static void Thread2()
		{
			for (int i = 1; i < 15; i++)
			{
				Console.WriteLine("Thread 2 is started at the position : " + i);
			}

		}
		static void Thread3()
		{
			for (int i = 1; i < 15; i++)
			{
				if(i==10)
				{
					Console.WriteLine("Thread 2 is sleeping for 10seconds");
					Thread.Sleep(10000);
				}
				Console.WriteLine("Thread 3 is started at the position : " + i);
			}

		}
		static void Main(string[] args) //Main Method
		{
			Thread T1 = new Thread(Thread1);
			Thread T2 = new Thread(Thread2);
			Thread T3 = new Thread(Thread3); //one main thread and 3 child threads

			T1.Start();
			T2.Start();
			T3.Start();
			Console.ReadLine();
		}
	}
}
