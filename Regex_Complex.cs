using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Complex
{
	class Program
	{
		static void Main(string[] args)
		{
			//part 1: the input string
			string input = "/content/alternate-1.aspx";

			//part 2: call Regex.Match.
			Match mch = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$", RegexOptions.IgnoreCase);
			
			//part 3: check the Match for success.
			if (mch.Success)
			{
				//part 4: get the group value and display it.
				string key = mch.Groups[1].Value;
				Console.WriteLine(key);
				Console.ReadKey();
			}
		}
	}
}
