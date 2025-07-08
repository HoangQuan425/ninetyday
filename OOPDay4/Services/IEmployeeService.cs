using OOPDay4.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Services
{
	public interface IEmployeeService
	{
		List<Employee> GetAll();
		bool Add(Employee e);
		bool Delete(string employeeId);
		bool Update(string employeeId, Employee e);
		Employee GetById(string employeeId);
		decimal CalculateEmployeeSalary(string id);
	}
}
