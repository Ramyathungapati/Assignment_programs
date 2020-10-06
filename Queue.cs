using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> MyQueue = new Queue<string>(); //Queue object Created
			MyQueue.Enqueue("programming");
			MyQueue.Enqueue("Is");
			MyQueue.Enqueue("Fun");
			MyQueue.Enqueue("C# programming");
			MyQueue.Enqueue("Technical traning");
			MyQueue.Enqueue("with Sachin");

			foreach(string DXC in MyQueue)
			{
				Console.WriteLine("Queue Elements entered are : " + DXC);
			}
			Console.WriteLine("Elements left after applying Dequeue method : " + MyQueue.Dequeue()); //FIFO?? Access the element which first present.
			Console.WriteLine("Elements of the Queue is : " + MyQueue.Peek());
			Console.WriteLine("the Current elements of the queue  : " + MyQueue.Count());

			Console.ReadKey();
		}
	}
}
