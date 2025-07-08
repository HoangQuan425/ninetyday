using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Entity
{
	public class Manager : Employee
	{
		public Manager(string id, string name, int age, DateOnly dateBirth, DateOnly hiredDate, DateOnly? leaveDate, decimal baseSalary, decimal allowance, decimal bonus, decimal tax, decimal overTimePay) : base(id, name, age, dateBirth, hiredDate, leaveDate, baseSalary, allowance, bonus, tax, overTimePay)
		{
		}

		protected override decimal CalculateSalary()
		{
			decimal LeaderShip = (BaseSalary + Bonus) * 5m/100m;
			decimal NetSalary = (BaseSalary + Allowance + Bonus + LeaderShip + OverTimePay) - Tax;
			if (NetSalary < 0) throw new ArgumentException("Net salary cannot be negative.");
			return NetSalary;
		}

		protected override void ShowInfo()
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
