using OOPDay4.Entity;

namespace OOPDay4.Strategies
{
	public class CSVExport : IExportStrategy
	{
		public void Export(List<Employee> employees)
		{
			if(employees == null)
			{
				throw new ArgumentNullException(nameof(employees), "employees are empty");
			}
			Console.WriteLine("Export by csv");
		}
	}
}
