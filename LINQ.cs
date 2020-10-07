using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpLINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 12, 45, 67, 93, 8, 61, 74, 52, 82, 97, 27, 49, 58, 79, 86, 14, 3, 23, 37, 92 };

			//			var brr = from i in arr where i > 40 orderby i descending select i;
			//			var brr = from i in arr where i > 30 orderby i ascending select i;

			//			foreach (int x in brr)
			//			{
			//				Console.WriteLine("Elements of the array are : " + x + " ");
			//				Console.ReadKey();
			//			}
			//		}
			//	}
			//}           
			int count = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 40)
				{
					count += 1;
				}
			}
			int[] brr = new int[count];
			int index = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > 40)
				{
					brr[index] = arr[i];
					index += 1;
				}
			}
			Array.Sort(brr); //Ascending Order
			Array.Reverse(brr); //Descending Order
			foreach (int x in brr)
			{
				Console.WriteLine("Elements of the array are : " + x + " ");
				Console.ReadKey();
			}
		}
	}
}
