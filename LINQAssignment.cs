using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			IList<Employee> EmployeeList = new List<Employee>()
			{ 
				new Employee() { EmployeeID = 1, EmployeeName= "RAMYA",EmployeeSalary=20000,EmployeeDesignation="Engineer" },
				new Employee() { EmployeeID = 2, EmployeeName= "NIDHI",EmployeeSalary=30000,EmployeeDesignation="Technical" },
				new Employee() { EmployeeID = 3, EmployeeName= "NANI",EmployeeSalary=25000,EmployeeDesignation="Software" },
				new Employee() { EmployeeID = 4, EmployeeName= "TEJU",EmployeeSalary=18000,EmployeeDesignation="Fresher" },
				new Employee() { EmployeeID = 5, EmployeeName= "PANDU",EmployeeSalary=28000,EmployeeDesignation="Assistant" },
				new Employee() { EmployeeID = 6, EmployeeName= "VARSHI",EmployeeSalary=29000,EmployeeDesignation="Manager" },

			};
			//Applying LINQ logic as same SQL
			var Employee = EmployeeList.Where(s => s.EmployeeSalary > 25000).Select(s => s).Where(st => st.EmployeeID > 1).Select(s => s.EmployeeName);
			var studentName1 = EmployeeList.Where(s => s.EmployeeSalary > 25).Select(s => s).Where(st => st.EmployeeID == 4).Select(s => s.EmployeeName);



			//second condition for better understanding.
			var youngEmployeeName = from s in EmployeeList
								   where s.EmployeeSalary > 20000 && s.EmployeeSalary < 30000
								   select new { EmployeeName = s.EmployeeName};

			youngEmployeeName.ToList().ForEach(s => Console.WriteLine(s.EmployeeName));


			//GroupBy execution

			var EmployeeGroupByDesignation = from s in EmployeeList
									         group s by s.EmployeeID into sb
									         orderby sb.Key
									         select new { sb.Key, sb };

			foreach (var group in EmployeeGroupByDesignation)
			{
				Console.WriteLine("EmployeeID {0} : ", group.Key);

			}
			foreach (var name in Employee)
			{
				Console.WriteLine(name);
			}
			Console.ReadKey();
		}
	}
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public int EmployeeSalary { get; set; }
		public string EmployeeDesignation{ get; set; }

	}
}
