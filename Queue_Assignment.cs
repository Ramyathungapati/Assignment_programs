using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> MyQueue = new Queue<int>(); //Queue object Created
			MyQueue.Enqueue(2);
			MyQueue.Enqueue(4);
			MyQueue.Enqueue(6);
			MyQueue.Enqueue(8);
			MyQueue.Enqueue(10);
			MyQueue.Enqueue(12);
			MyQueue.Enqueue(14);
			MyQueue.Enqueue(16);
			MyQueue.Enqueue(18);
			MyQueue.Enqueue(20);

			foreach(int DXC in MyQueue)
			{
				Console.WriteLine("Queue Elements entered are : " + DXC);
			}
			
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue()); //FIFO?? Access the element which first present.
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Dequeue());

			foreach (int DXC in MyQueue)
			{
				Console.WriteLine("Elements are : " + DXC);
			}
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Peek());
			Console.WriteLine("Elements after applying Dequeue method : " + MyQueue.Count());
			Console.WriteLine("The element exist in the queue is : " + MyQueue.Contains(20));
			Console.WriteLine("The element exist in the queue is : " + MyQueue.Contains(12));



			Console.ReadKey();
		}
	}
}
