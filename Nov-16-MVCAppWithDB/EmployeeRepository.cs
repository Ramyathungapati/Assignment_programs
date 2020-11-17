using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppModels;
using System.Data.SqlClient;
using MyAppDB.DbOperations;


namespace MyAppDB.DbOperations
{
	public class EmployeeRepository
	{
		public int AddEmployee(EmployeeModel model)
		{
			using (var context = new EmployeeDBEntities())
			{
				Employee emp = new Employee()
				{
					FirstName = model.FirstName,
					LastName = model.LastName,
					Email = model.Email,
					Code = model.Code
					
				};
				if(model.Address != null)
				{
					emp.Address = new Address()
					{
						Details = model.Address.Details,
						State = model.Address.State,
						Country = model.Address.Country,
					};
				}

				context.Employee.Add(emp);

				context.SaveChanges();

				return emp.Id;
			}
		}

		public List<EmployeeModel>GetAllEmployees()
		{
			using (var context = new EmployeeDBEntities())
			{
				var result = context.Employee
					.Select(x => new EmployeeModel()
					{
						Id = x.Id,
						AddressId = x.AddressId,
						Code = x.Code,
						Email = x.Email,
						FirstName = x.FirstName,
						LastName = x.LastName,
						Address = new AddressModel()
						{
							Id = x.Address.Id,
							Details = x.Address.Details,
							Country = x.Address.Country,
							State = x.Address.State
						}
					}).ToList();

				return result;
			}
		}
	}
}
