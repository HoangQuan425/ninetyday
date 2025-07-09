using OOPDay4.Entity;
using OOPDay4.Strategies;

namespace OOPDay4.Services
{
	public class ExportService
	{
		private readonly IExportStrategy _strategy;

		public ExportService(IExportStrategy strategy)
		{
			_strategy = strategy;
		}
		public void Export(List<Employee> employees)
		{
			if (employees == null)
			{
				throw new ArgumentNullException("employees are empty");
			}
			_strategy.Export(employees);
		}
	}
}
