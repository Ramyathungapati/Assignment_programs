using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*SINGLE THREADED MODULE*/

	//Until and unless the currentthread excuted completely the other thread will stay idle


namespace ThreadTest
{
	class Program
	{
		static void Thread1()
		{
			for(int i=1;i<15;i++)
			{
				Console.WriteLine("Thread 1 is started");
				Console.WriteLine("Thread 1 is started at the position : " +i);
				
			}
			Console.WriteLine("Thread1 Got Exit");
			Console.WriteLine();
		}
		static void Thread2()
		{
			for (int i = 1; i < 15; i++)
			{
				if(i==14)
				{
					Console.WriteLine("Thread 2 is sleeping for 55 seconds");
					Thread.Sleep(14000);
				}
				Console.WriteLine("Thread 2 is started");
				Console.WriteLine("Thread 2 is started at the position : " + i);
			}
			Console.WriteLine("Thread2 Got Exit");
			Console.WriteLine();
		}
		static void Thread3()
		{
			for (int i = 1; i < 15; i++)
			{
				Console.WriteLine("Thread 3 is started");
				Console.WriteLine("Thread 3 is started at the position : " + i);
				
			}
			Console.WriteLine("Thread3 Got Exit");
			Console.WriteLine();
		}

		static void Main(string[] args) //This is also a Thread
		{
			//Instatiate the methods created
			Thread1();
			Thread2();
			Thread3();
			Console.WriteLine("Main Thread Executed all the threads from the program");

			Console.ReadLine();
		}
	}
}
