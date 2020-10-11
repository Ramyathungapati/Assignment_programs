using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> A = new Stack<string>(); //object creation
			A.Push("RAMYA"); //Push Method
			A.Push("ABHI");
			A.Push("PANZEE");

			foreach(string stack in A)
			{
				Console.WriteLine("Elements in A are : " +stack);
			}

			Console.WriteLine("After applying pop : " + A.Pop()); //Pop method
			Console.WriteLine("After applying pop : " + A.Pop());

			Console.WriteLine("Peak element of stack : " + A.Peek()); //Peek Method

			Console.WriteLine(A.Contains("RAMYA"));
			Console.WriteLine(A.Contains("TEJU"));

			Console.ReadLine();
		}
	}
}
