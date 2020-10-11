using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Delegate
{
	//****Defining delegate*******
	public delegate int AddnumsDelegate(int x, int y);
	public delegate double MultiplyDelegate(int x, float y);
	public delegate void MethodDelegate(string str);

	class Program
	{
		public static int Addnums(int x, int y)
		{
			return x + y;
		}

		public static double Multiply(int x, float y)
		{
			return x * y;
		}
		//**********Main Method*********

		public static void Method(string Str)
		{
			Console.WriteLine("Thungapati " + Str);
		}

		static void Main(string[] args)
		{
			AddnumsDelegate obj1 = new AddnumsDelegate(Addnums);
			int result = obj1.Invoke(5, 5);
			Console.WriteLine(result);

			MultiplyDelegate obj2 = new MultiplyDelegate(Multiply);
			double result2 = obj2.Invoke(4, 5);
			Console.WriteLine(result2);

			MethodDelegate obj3 = new MethodDelegate(Method);
			obj3.Invoke("RAMYA");

			Console.ReadLine();
		}
	}
}
