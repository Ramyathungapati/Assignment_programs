using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgmnt_LINQ
{
	
	class Program
	{
		
		static void Main(string[] args)
		{
			int[] arr = { 98, 56, 72, 34, 12, 66, 43 };

			var brr = from i in arr where i > 12 orderby i descending select i;
			var brr1 = from i in arr where i > 12 orderby i ascending select i;
			foreach (int x in brr)
			{
				Console.Write(x + " ");

			}

			foreach (int x1 in brr1)
			{
				Console.Write(x1 + " ");

			}
			Console.ReadLine();
		}
	}
}
			