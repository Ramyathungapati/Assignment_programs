using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Assignment
{
	class Program
	{
		public string Thread1(string str)
		{
			for (int i = 1; i < 10; i++)
			{
				Console.WriteLine(" Thread1 started " + i);
			}
			return str;
		}

		public int Thread2(int x, int y)
		{

			for (int i = 1; i < 10; i++)
			{
				if (i == 4)
				{
					Console.WriteLine("thread2 will be in sleep for 10 sec");
					Thread.Sleep(10000);  //thread sleep
				}
				Console.WriteLine(" Thread2 started " + i);
			}
			return x * y;
		}

		public string Thread3()
		{
			for (int i = 1; i < 10; i++)
			{
				Console.WriteLine(" Thread 3 started " + i);
			}
			return "Thread 3";		
		}

		static void Main(string[] args)
		{
			Program obj = new Program(); //object creation
			Console.WriteLine(obj.Thread1("Thread Exit"));
			Console.WriteLine(obj.Thread2(10, 50));
			Console.WriteLine(obj.Thread3());

			Console.ReadKey();
		}
	}
}
