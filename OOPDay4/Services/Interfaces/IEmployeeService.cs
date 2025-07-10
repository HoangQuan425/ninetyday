using OOPDay4.Entity;

namespace OOPDay4.Services.Interfaces
{
	public interface IEmployeeService
	{
		List<Employee> GetAll();
		bool Add(Employee e);
		bool Delete(string employeeId);
		bool Update(string employeeId, Employee e);
		Employee GetById(string employeeId);
	}
}
