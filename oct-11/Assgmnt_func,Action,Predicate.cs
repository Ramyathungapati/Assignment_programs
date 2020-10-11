using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_func_Action_Predicate
{

	class Program
	{
		static void Main(string[] args)
		{
			Func<string, string> obj1 = name1 => "Ramya" + name1;
			string namee = obj1.Invoke("Sree");
			Console.WriteLine(namee);

			Action<string> obj2 = name2 => Console.WriteLine("Thungapati");
			obj2.Invoke("HAI");

			Predicate<int> obj3 = value =>
			{
				if (value > 5)
					return true;
				return false;
			};
			bool val = obj3.Invoke(15);
			Console.WriteLine(val);
			Console.ReadLine();
		}
	}
}
