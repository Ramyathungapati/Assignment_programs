using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			//step 1: create new Regex.
			Regex rg = new Regex(@"\d+");

			//step 2:call Match on Regex instance.
			Match mch = rg.Match("a55a");

			//step 3: test for success.
			if (mch.Success)
			{
				Console.WriteLine("MATCH VALUE : " + mch.Value);
				Console.ReadKey();
			}

		}
	}
}
