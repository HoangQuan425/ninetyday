using OOPDay4.Entity;
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

		public bool Add(Employee e)
		{
			if (e == null)
			{
				throw new Exception("employee is null");
			}
			if (string.IsNullOrEmpty(e.Id))
			{
				throw new Exception("id cannot be null or empty");
			}
			foreach(Employee emp in _employee)
			{
				if (emp.Id.Equals(e.Id))
				{
					throw new Exception("id already exists");
				}
			}
			_employee.Add(e);
			return true;
		}

		public bool Delete(string employeeId)
		{
			if(string.IsNullOrEmpty(employeeId))
			{
				throw new Exception("id can not be null or empty");
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
				throw new Exception("list is empty");
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
			return null;
		}

		public bool Update(string employeeId, Employee e)
		{
			if (e==null)
			{
				throw new Exception("employee can not be null or empty");
			}
			if (string.IsNullOrEmpty(employeeId))
			{
				throw new Exception("employee id can not be null or empty");
			}
			
			foreach (Employee emp in _employee)
			{
				if (emp.Id.Equals(employeeId))
				{
					emp.Name = e.Name;
					emp.Age = e.Age;
					emp.LeaveDate = e.LeaveDate;
					emp.HiredDate = e.HiredDate;
					emp.Allowance = e.Allowance;
					emp.OverTimePay = e.OverTimePay;
					emp.BaseSalary = e.BaseSalary;
					emp.Bonus = e.Bonus;
					emp.DateBirth = e.DateBirth;
					return true;
				}
			}
			return false;
		}
	}
}
