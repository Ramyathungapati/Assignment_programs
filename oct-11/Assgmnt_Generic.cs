using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_Generic
{
	class check<T>//type parameter
	{
		T data;

		public check(T check)//check is assigned to type parameter
		{
			this.data = check;
		}
		public void test()//sending a value to check
		{
			Console.WriteLine("value pass to intilizer is:" + this.data);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			check<int> result = new check<int>(100);
			check<string> result1 = new check<string>("sravani");

			result.test();
			result1.test();
		}
	}
}
