using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
			//inserting elements
			MyDictionary.Add(1, "Banglore");
			MyDictionary.Add(2, "Mumbai");
			MyDictionary.Add(3, "Pune");
			MyDictionary.Add(4, "Hyderabad");
			MyDictionary.Add(5, "Chennai");
			MyDictionary.Add(6, "Delhi");
			MyDictionary[7] = "kolkota";
			MyDictionary[8] = "Ahmmedabad";
			MyDictionary[9] = "Nodia";
			MyDictionary[10] = "Trivunanthapuram";
			Console.WriteLine("Elements in dictionary are : ");

			foreach(KeyValuePair<int,string>dictionary in MyDictionary)
			{
				Console.WriteLine("Elements are : " + dictionary.Key + " " + dictionary.Value);
			}
			//remove
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(10));
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(9));
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(8));
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(7));
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(6));
			Console.WriteLine("elements after remove: " + MyDictionary.Remove(5));
			Console.WriteLine("elements are : ");
			
			foreach (KeyValuePair<int, string> dictionary in MyDictionary)
			{
				Console.WriteLine("Elements are : " + dictionary.Key + " " + dictionary.Value);
			}
			//count
			Console.WriteLine("the no of elements present in dictionary: " + MyDictionary.Count());
			Console.ReadKey();

		}
	}
}
