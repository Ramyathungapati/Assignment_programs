using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Anonymous
{
	//****Defining delegate*******
	public delegate int AddnumsDelegate(int x, int y);
	public delegate double MultiplyDelegate(int x, float y);
	public delegate bool CheckLengthDelegate(string str);

	class Program
	{ 
		static void Main(string[] args)
		{
			AddnumsDelegate obj1 = delegate (int x, int y) //object creation
			{
				return (x + y);
			};
			int result = obj1.Invoke(5, 5);
			Console.WriteLine(result);

			MultiplyDelegate obj2 = delegate (int x, float y) //object creation
			{
				return (x * y);
			};
			double result1 = obj2.Invoke(3, 3.4f);
			Console.WriteLine(result1);

			CheckLengthDelegate obj3 = delegate (string name)
			{
				if (name.Length > 3)
					return true;
				return false;
			};
			bool check = obj3.Invoke("CSHARP");
			Console.WriteLine(check);

			Console.ReadLine();
		}
	}
}
