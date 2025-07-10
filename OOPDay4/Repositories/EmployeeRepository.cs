using OOPDay4.Entity;
using OOPDay4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly List<Employee> _employee;

		public EmployeeRepository()
		{
			_employee = new List<Employee>();
		}

		public EmployeeRepository(List<Employee> employee)
		{
			this._employee = employee;
		}

		public bool Add(Employee employee)
		{
			if (employee == null)
			{
				throw new ArgumentNullException(nameof(employee), "employee is null");
			}
			if (string.IsNullOrEmpty(employee.Id))
			{
				throw new ArgumentNullException(nameof(employee.Id), "id cannot be null or empty");
			}
			foreach(Employee emp in _employee)
			{
				if (emp.Id.Equals(employee.Id))
				{
					throw new DuplicateEmployeeIdException($"Employee with {employee.Id} already exists");
				}
			}
			_employee.Add(employee);
			return true;
		}

		public bool Delete(string employeeId)
		{
			if(string.IsNullOrEmpty(employeeId))
			{
				throw new ArgumentNullException(nameof(employeeId), "id can not be null or empty");
			}
			
			foreach (Employee e in _employee)
			{
				if (e.Id.Equals(employeeId))
				{
					_employee.Remove(e);
					return true;
				}
			}
			return false;
		}

		public List<Employee> GetAll()
		{
			if(_employee.Count == 0)
			{
				return new List<Employee>();
			}
			
			return _employee;
		}

		public Employee GetById(string employeeId)
		{
			if (string.IsNullOrEmpty(employeeId))
			{
				throw new ArgumentNullException("employeeId cannot be null or empty");
			}
			foreach (Employee e in _employee)
			{
				if (e.Id.Equals(employeeId))
				{
					return e;
				}
			}
			throw new EmployeeNotFoundException($"Employee with id {employeeId} not found");
		}

		public bool Update(string employeeId, Employee employee)
		{
			if (employee == null)
			{
				throw new ArgumentNullException("employee can not be null or empty");
			}
			if (string.IsNullOrEmpty(employeeId))
			{
				throw new ArgumentNullException("employee id can not be null or empty");
			}
			
			foreach (Employee emp in _employee)
			{
				if (emp.Id.Equals(employeeId))
				{
					emp.Name = employee.Name;
					emp.Age = employee.Age;
					emp.LeaveDate = employee.LeaveDate;
					emp.HiredDate = employee.HiredDate;
					emp.Allowance = employee.Allowance;
					emp.OverTimePay = employee.OverTimePay;
					emp.BaseSalary = employee.BaseSalary;
					emp.Bonus = employee.Bonus;
					emp.DateBirth = employee.DateBirth;
					return true;
				}
			}
			return false;
		}
	}
}
