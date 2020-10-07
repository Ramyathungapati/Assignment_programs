using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharpRegularExpression
{
	class Program
	{
		static void Main(string[] args)
		{
			//Apply regex and find for match value. value=99, value=55
			//step 1: Create a RegEx- Object needs to e created.

			Regex example = new Regex(@"\d+");

			//Step 2: Call the match on the regex instanously

			Match Match = example.Match("This day is started beautifully");
			//Match() one of the regular expression method
			//Method of RegEx are 1.Match() 2.IsMatch() 3.MatchNext() 4.Replace()
			//Method of Lists add(), remove(), count()
			//push() pop() peek()
			//enqueue() dequeue() peek()
			//add() remove() count()
			//Step 3: Test for validation/success

			if (Match.Success)
			{
				Console.WriteLine("The match value of the digit is : " + Match.Value);
				Console.WriteLine("Pattern matched");
			}
			//output : art : art /B ==> start<middle>end

			string test = "aabb";
			//Match the start of a string
			if (Regex.IsMatch(test,"(aa|bb)"))
			{
				Console.WriteLine("Pattern matched, where string is starting with");
			}
			string value = "10 and 20 and 30 and 40 crazy 50 beautiful 60 programming 70 is fun 80";
			//step 1: get the first match
			Match mch = Regex.Match(value, @"\d+"); //find the digits present in the string!!!!
			if(mch.Success)
			{
				Console.WriteLine("Pattern matched and the digits are : " + mch.Value); // This will gives me output of 10
			}
			//step 2: Get second Match;

			mch = mch.NextMatch();
			if(mch.Success)
			{
				Console.WriteLine("The second executed and the digits are : " + mch.Value); //This will gives me an output of 20 
				Console.ReadKey();
			}
		}	
	}
}
