using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQJoins
{


	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeDesignation { get; set; }
		public string EmployeeName { get; set; }
		public int EmployeeSalary { get; set; }
	}

	class LinQ
	{

		static void Main(string[] args)
		{

			List<Employee> emp1 = new List<Employee>() {
			new Employee() { EmployeeID = 1, EmployeeName= "Ramya",  EmployeeSalary = 30000, EmployeeDesignation = "Fresher" },
			new Employee() { EmployeeID = 2, EmployeeName= "Abhi",  EmployeeSalary = 10000, EmployeeDesignation = "HR" },
			};
			List<Employee> emp2 = new List<Employee>() {
			new Employee() { EmployeeID = 2, EmployeeName= "Sowmya",  EmployeeSalary = 25000, EmployeeDesignation = "Sofftware" },
			new Employee() { EmployeeID = 3, EmployeeName= "Nandu",  EmployeeSalary = 28000, EmployeeDesignation = "TechManager" },
			};
			var innerJoinQuery = from e1 in emp1
								 join e2 in emp2
								 on e1.EmployeeID equals e2.EmployeeID
								 select new { EmployeeName = e1.EmployeeName, EmployeeDesignation = e2.EmployeeDesignation };
			foreach (var x in innerJoinQuery)

			{
				Console.WriteLine("Employee {0} EmployeeDesignation {1} ", x.EmployeeName, x.EmployeeDesignation);
			}
			Console.ReadKey();

		}
	}
}
