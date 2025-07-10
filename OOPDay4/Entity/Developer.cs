using OOPDay4.Interfaces;

namespace OOPDay4.Entity
{
	public class Developer : Employee, IWork, IReportToManager
	{
		public Developer(string id, string name, int age, DateOnly dateBirth, DateOnly hiredDate, DateOnly? leaveDate, decimal baseSalary, decimal allowance, decimal bonus, decimal tax, decimal overTimePay) : base(id, name, age, dateBirth, hiredDate, leaveDate, baseSalary, allowance, bonus, tax, overTimePay)
		{
		}

		public void DoWork()
		{
			Console.WriteLine($"Developer: {Name} is working on their assigned task, code and fix bug.");
		}

		public Report ReportToManager(string managerId, string message)
		{
			//return $"developer {Name} report to their manager with id: {managerId}";
			if(managerId == null)
			{
				throw new ArgumentNullException(nameof(managerId), "manager id is null or empty");
			}
			Report report = new Report(Id, managerId, message, DateTime.UtcNow);
			return report;
		}

		protected override decimal CalculateSalary()
		{
			decimal NetSalary = (BaseSalary + Allowance + Bonus + OverTimePay) - Tax;
			if (NetSalary < 0) throw new ArgumentException("Net salary cannot be negative.");
			return NetSalary;
		}

		public override void ShowInfo()
		{
			Console.WriteLine($"id: {Id}");
			Console.WriteLine($"name: {Name}");
			Console.WriteLine($"age: {Age}");
			Console.WriteLine($"Date birth: {DateBirth}");
			Console.WriteLine($"hired date: {HiredDate}");
			Console.WriteLine($"leave date: {LeaveDate}");

		}
	}
}
