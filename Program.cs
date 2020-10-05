using System;
using System.Collections.Generic;

namespace CSharpStack
{
	class Program
	{
		static void Main(string[] args)
		{

			Stack<string> Mystack = new Stack<string>(); //created an object of stack
			Mystack.Push("RAMYA"); //push method takes one argument
			Mystack.Push("Engineer");
			Mystack.Push("Fresher"); //Accessing the element within Mystack
			Mystack.Push("C# programming");
			Mystack.Push("Stack Collection");

			foreach(string stack in Mystack)
			{
				Console.WriteLine("Elements of Mystack are : " + stack);
			}
			Console.WriteLine("The Elements after applying pop : " + Mystack.Pop()); //stack collection
			Console.WriteLine("The Elements after applying pop : " + Mystack.Pop()); //C# programming
			Console.WriteLine("The Elements after applying pop : " + Mystack.Pop()); //Fresher
			Console.WriteLine("The Elements after applying pop : " + Mystack.Pop()); //Engineer

			Console.WriteLine("The peak element of the stack is : " + Mystack.Peek()); //to find the top/peek of Mystack.
			Console.WriteLine("The element left in Mystack pop operation : " + Mystack); //to find the top/peek of Mystack.

			Console.WriteLine(Mystack.Contains("RAMYA"));
			Console.WriteLine(Mystack.Contains("Ramya"));

			Console.ReadKey();
		}
	}
}
