using OOPDay4.Entity;
using OOPDay4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public bool Add(Employee e)
		{
			if(e == null)
			{
				throw new Exception("employee is null or empty");
			}
			var result = _employeeRepository.Add(e);
			return result;
		}

		public decimal CalculateEmployeeSalary(string id)
		{
			if(string.IsNullOrEmpty(id)) throw new Exception("employeeId is null or empty");
			var employee = _employeeRepository.GetById(id);
			if (employee == null) {
				throw new Exception("employee is null or empty");
			}
			var result = employee.DisplaySalary();
			return result;
		}

		public bool Delete(string employeeId)
		{
			if (string.IsNullOrEmpty(employeeId)) throw new Exception("employeeId is null or empty");
			var result = _employeeRepository.Delete(employeeId);
			return result;
		}

		public List<Employee> GetAll()
		{
			var result = _employeeRepository.GetAll();
			return result;
		}

		public Employee GetById(string employeeId)
		{
			if(string.IsNullOrEmpty(employeeId)) throw new Exception("employeeId is null or empty");
			var result = _employeeRepository.GetById(employeeId);
			return result;
		}

		public bool Update(string employeeId, Employee e)
		{
			if(e==null) throw new Exception("employee is null or empty");
			if (string.IsNullOrEmpty(employeeId)) throw new Exception("employeeId is null or empty");
			var result = _employeeRepository.Update(employeeId, e);
			return result;
		}
	}
}
