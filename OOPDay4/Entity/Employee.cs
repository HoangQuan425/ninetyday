namespace OOPDay4.Entity
{
	public abstract class Employee
	{
		private string _id;

		public string Id
		{
			get { return _id; }
			private set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new Exception("id can not empty");
				}
				_id = value;
			}
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new Exception("name can not empty");
				}
				_name = value;
			}
		}

		private int _age;

		public int Age
		{
			get { return _age; }
			set
			{
				if (value < 18)
				{
					throw new Exception("not old enough");
				}
				_age = value;
			}
		}
		private DateOnly _dateBirth;

		public DateOnly DateBirth
		{
			get { return _dateBirth; }
			set
			{
				_dateBirth = value;
			}
		}
		private DateOnly _hiredDate;

		public DateOnly HiredDate
		{
			get { return _hiredDate; }
			set
			{
				_hiredDate = value;
			}
		}

		private DateOnly? _leaveDate;

		public DateOnly? LeaveDate
		{
			get { return _leaveDate; }
			set
			{
				if (value.HasValue && value <= _hiredDate)
				{
					throw new Exception("leave date <= hired date");
				}
				_leaveDate = value;
			}
		}

		private decimal _baseSalary;

		public decimal BaseSalary
		{
			get { return _baseSalary; }
			set
			{
				if (value <= 0)
				{
					throw new Exception("salary can not be 0 or a negative number");
				}
				_baseSalary = value;
			}
		}

		private decimal _allowance;

		public decimal Allowance
		{
			get { return _allowance; }
			set
			{
				if (value < 0)
				{
					throw new Exception("allowance can not < 0");
				}
				_allowance = value;
			}
		}
		private decimal _bonus;

		public decimal Bonus
		{
			get { return _bonus; }
			set
			{
				if (value < 0)
				{
					throw new Exception("bonus can not < 0");
				}
				_bonus = value;
			}
		}
		private decimal _tax;

		public decimal Tax
		{
			get { return _tax; }
			set
			{
				_tax = value;
			}
		}
		private decimal _overTimePay;

		public decimal OverTimePay
		{
			get { return _overTimePay; }
			set
			{
				if (value < 0)
				{
					throw new Exception("overTimePay can not < 0");
				}
				_overTimePay = value;
			}
		}

		public Employee(string id, string name, int age, DateOnly dateBirth, DateOnly hiredDate, DateOnly? leaveDate, decimal baseSalary, decimal allowance, decimal bonus, decimal tax, decimal overTimePay)
		{
			if (string.IsNullOrEmpty(id))
				throw new ArgumentException("id cannot be null or empty");
			Id = id;
			Name = name;
			Age = age;
			DateBirth = dateBirth;
			HiredDate = hiredDate;
			LeaveDate = leaveDate;
			BaseSalary = baseSalary;
			Allowance = allowance;
			Bonus = bonus;
			Tax = tax;
			OverTimePay = overTimePay;
		}



		public abstract void ShowInfo();
		protected abstract decimal CalculateSalary();
		public decimal DisplaySalary()
		{
			var salary = CalculateSalary();
			Console.WriteLine($"salary: {salary}");
			return salary;
		}
	}
}
