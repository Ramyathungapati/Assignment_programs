using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpList
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("C# Lists");
			//create an object for list

			//syntax
			//<Datatype Variable name = new List<datatype>();
			var user = new List<string>();

			user.Add("Programming");
			user.Add("is fun");
			user.Add("C# Lists in Collections");
			user.Add("Sachin");
			user.Add("Technical training");

			Console.WriteLine("List Created");
			foreach(var list in user)
			{
				Console.WriteLine("The elements of the lists are : " + list);

			}
			Console.WriteLine("Checking for remove method : " + user.Remove("Sachin"));

			var mobile = new List<string>() { "Sachin","Tendulkar","Ganguly","Rahul", "Dravid" };

			foreach (var docker in mobile)
			{
				Console.WriteLine("Another way of creating a list : " + docker);
			}
				Console.WriteLine("The 1st index of the List is : " + mobile[0]);
				Console.WriteLine("The 2nd index of the List is : " + mobile[1]);
				Console.WriteLine("The 3rd index of the List is : " + mobile[2]);
				Console.WriteLine("The 4th index of the List is : " + mobile[3]);
				Console.WriteLine("The 5th index of the List is : " + mobile[4]);
				Console.WriteLine("The 6th index of the List is : " + mobile[5]);
				Console.WriteLine("The 7th index of the List is : " + mobile[6]);//what would be my output? IndexOutOfBound
				//The list has total elements of 6 however theres no 7th element in list
				//IndexOutOfBound /==>/ This means the index overflow!

		
			Console.ReadKey();
		}
	}
}
