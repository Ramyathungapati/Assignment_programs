using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
	public delegate void AddDelegate(int a, int b);
	public delegate string sayDelegate(string str);

	class Program
	{
		//Non-Static Method
		public void Addnums(int a, int b)
		{
			Console.WriteLine(a + b);
		}

		//static Method
		public static string sayHello(string name)
		{
			Console.WriteLine( " Hello" + name + "Good Afternoon");
			return name;
		}

		static void Main(string[] args)
		{
			Program p = new Program(); // Instantiated to class program

			//p.Addnums(100, 50); //output =150;

			AddDelegate Ad = new AddDelegate(p.Addnums); //Passing the mmethod addnums to the delegates
			sayDelegate Sd = new sayDelegate(sayHello); //passing the method SayHello to Delegate

			Ad(100, 50);
			Sd(" Folks ");

			Console.ReadKey();
		}
	}
}
