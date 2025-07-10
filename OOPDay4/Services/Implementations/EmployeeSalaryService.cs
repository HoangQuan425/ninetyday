using OOPDay4.Exceptions;
using OOPDay4.Repositories;
using OOPDay4.Services.Interfaces;

namespace OOPDay4.Services.Implementations
{
	public class EmployeeSalaryService : IEmployeeSalaryService
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeSalaryService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public decimal CalculateEmployeeSalary(string employeeId)
		{
			if (string.IsNullOrEmpty(employeeId))
			{
				throw new ArgumentNullException(nameof(employeeId), "id is null or empty");
			}
			var employee = _employeeRepository.GetById(employeeId);
			if (employee == null)
			{
				throw new EmployeeNotFoundException("Employee not found");
			}
			return employee.DisplaySalary();
		}
	}
}
