using OOPDay4.Entity;
using OOPDay4.Repositories;
using OOPDay4.Services.Interfaces;

namespace OOPDay4.Services.Implementations
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
