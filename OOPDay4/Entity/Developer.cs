using OOPDay4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Entity
{
	public class Developer : Employee, IWork, IReportToManager
	{
		public Developer(string id, string name, int age, DateOnly dateBirth, DateOnly hiredDate, DateOnly? leaveDate, decimal baseSalary, decimal allowance, decimal bonus, decimal tax, decimal overTimePay) : base(id, name, age, dateBirth, hiredDate, leaveDate, baseSalary, allowance, bonus, tax, overTimePay)
		{
		}

		public void DoWork()
		{
			Console.WriteLine($"{Name} is working on their assigned task.");
		}

		public string ReportToManager(string managerId)
		{
			return $"developer {Name} report to manager with id: {managerId}";
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
