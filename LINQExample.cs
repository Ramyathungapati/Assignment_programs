using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
	class Program
	{
		static void Main(string[] args)
		{
			//Implement the LINQ on Collections - LIST example
			IList<Student> studentList = new List<Student>()
			{
				//4 students //4ID //4Name //4age //4Batch
				new Student() { studentID =2, StudentName ="RAMYA", Age=27, BatchID=101},
				new Student() { studentID =3, StudentName ="ABHI", Age=65, BatchID=102},
				new Student() { studentID =4, StudentName ="RAHUL", Age=80, BatchID=103},
				new Student() { studentID =5, StudentName ="CHINTU", Age=100, BatchID=104},
			};
			//Applying LINQ logic as same SQL

			var studentName = studentList.Where(s => s.Age > 18).Select(s => s).Where(st => st.BatchID > 1).Select(s => s.StudentName);
			var studentName1 = studentList.Where(s => s.Age > 25).Select(s => s).Where(st => st.studentID == 4).Select(s => s.StudentName);

			//second condition for better understanding.
			var youngstudentName = from s in studentList
								   where s.Age > 12 && s.Age < 30
								   select new { studentName = s.StudentName };
			youngstudentName.ToList().ForEach(s => Console.WriteLine(s.studentName));


			//GroupBy execution

			var studentGroupByBatch = from s in studentList
									  group s by s.BatchID into sb
									  orderby sb.Key
									  select new { sb.Key, sb };

			//Groupby Query
			var studentGroupByBatch1 = from s in studentList
									   where s.BatchID > 0 //Query Statement
									   where s.Age>18   //one query statement
									   where s.studentID>1 //another query statement
									   group s by s.BatchID into sb
									   orderby sb.Key
									   select new { sb.Key, sb };
			foreach(var group in studentGroupByBatch1)
			{
				Console.WriteLine("BatchID {0} : ", group.Key);
			}


			foreach (var group in studentGroupByBatch)
			{
				Console.WriteLine("BatchID {0} : ",group.Key);

			}
									
									
		//10 ==> different conditions 4! 4*4
			foreach (var name in studentName)
			{
				Console.WriteLine(name);
			}
			foreach (var name1 in studentName1)
			{
				Console.WriteLine(name1);

			}
			Console.ReadKey();
		}
	
	}
	public class Student
	{
		public int studentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
		public int BatchID { get; set; }





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLinq2
	{
		public class example
		{
			public int EmpID { get; set; }
			public string EmpName { get; set; }
			public int EmpSalary { get; set; }
			public string EmpDes { get; set; }
		}
		class linq
		{
			static void Main(string[] args)
			{
				List<example> ex = new List<example>()
			{
				 new example() { EmpID = 1, EmpName = "soumya", EmpSalary= 20000, EmpDes = "Associate" },
				  new example() { EmpID = 2, EmpName = "swathi", EmpSalary=25000, EmpDes = "Associate" },
				   new example() { EmpID = 3, EmpName = "usha", EmpSalary= 35000, EmpDes = "Lead" },
					new example() { EmpID = 4, EmpName = "krupa", EmpSalary=50000, EmpDes = "Manager" },
			};
				var name = ex.Where(e => e.EmpSalary > 20000).Select(e => e).Where(e => e.EmpID > 1).Select(e => e.EmpName);

				var name1 = ex.Where(e => e.EmpDes == "Associate").Select(e => e).Where(e => e.EmpID > 0).Select(e => e.EmpID);

				var name2 = from e in ex
							where e.EmpID > 1 && e.EmpID < 4
							select new { e.EmpName };

				//*************Sorting the names*************using GroupBy clause
				var group = from e in ex
							group e by e.EmpName into em
							orderby em.Key
							select new { em.Key, em };




				foreach (var x in name)
				{
					Console.WriteLine(x);//swathi,uha,krupa
				}
				foreach (var y in name1)
				{
					Console.WriteLine(y);//1,2
				}
				foreach (var z in name2)
				{
					Console.WriteLine(z);//swathi,usha
				}
				foreach (var a in group)
				{
					Console.WriteLine("EmpName{0}", a.Key);
				}
				Console.ReadKey();
			}
		}
	}

}
}


