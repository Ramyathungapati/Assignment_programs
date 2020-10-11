using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Lambda
{
	//Defining delegate

	public delegate double AddnumsDelegate(int x, float y);
	public delegate int MultiplyDelegate(int x, int y);
	public delegate void NamesDelegate(string str);

	class Program
	{
		static void Main(string[] args)
		{
			AddnumsDelegate obj1 = (int x, float y) => //Lambda expression
			{
				return (x + y); //return operation
			};
			double result = obj1.Invoke(5, 5.5f); //Invoking values
			Console.WriteLine(result);

			MultiplyDelegate obj2 = (int x, int y) =>
			{
				return (x + y);
			};
			int result1 = obj2.Invoke(50, 50);
			Console.WriteLine(result1);

			NamesDelegate obj3 = Ramya =>
			{
				Console.WriteLine(" Hai " + Ramya + " welcome ");
			};
			obj3.Invoke("Ramya");

			Console.ReadLine();
		}
	}
}
