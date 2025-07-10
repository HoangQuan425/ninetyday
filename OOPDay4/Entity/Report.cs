namespace OOPDay4.Entity
{
	public class Report
	{
		public string ReporterId { get; private set; }
		public string ManagerId { get; private set; }
		public string Message { get; private set; }
		public DateTime ReportTime { get; private set; }
		public Report(string reporterId, string managerId, string message, DateTime reportTime)
		{
			ReporterId = reporterId;
			ManagerId = managerId;
			Message = message;
			ReportTime = reportTime;
		}
	}
}
