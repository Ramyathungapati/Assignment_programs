using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Thread
{
	class Program
	{
		static string Thread1()
		{
			return "Thread1 started";
		}

		static string Thread2()
		{
			return "Thread2 started";
		}
		static string Thread3()
		{
			return "Thread3 started";
		}
		static void Main(string[] args)
		{
			string str1 = Thread1();
			Console.WriteLine(str1);

			string str2 = Thread2();
			Console.WriteLine(str2);

			string str3 = Thread3();
			Console.WriteLine(str3);

			Console.ReadLine();
		}
	}
}
