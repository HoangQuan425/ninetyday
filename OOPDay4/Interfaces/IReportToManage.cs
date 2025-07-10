using OOPDay4.Entity;

namespace OOPDay4.Interfaces
{
	public interface IReportToManager
	{
		Report ReportToManager(string managerId, string message);
	}
}
