using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThread_Assignment
{
	class Program
	{
		//Method
		public string Thread1(string x, string y)
		{
			return x + y;
		}
		public int Thread2(int x, int y)
		{
			return x / y;
		}
		public int Thread3(int x)
		{
			return x * x;
		}

		static void Main(string[] args)
		{
			Program p = new Program(); //object creation for class

			Thread obj1 = new Thread(delegate() //delegate method
			{
				Console.WriteLine("String Concatenation : " + p.Thread1(" Ramya ", " Thungapati ")); //thread1 concatenation
			});

			Thread obj2 = new Thread(delegate () //delegate method
			{
				Console.WriteLine("divison of numbers : " + p.Thread2(5, 5)); //thread2 division 
			});

			Thread obj3 = new Thread(delegate () //delegate method
			{
				Console.WriteLine("square of numbers : " + p.Thread3(5)); //thread3 square of the number
			});

			obj1.Start();
			obj2.Start();
			obj3.Start();

			Console.ReadLine();
		}
	}
}
