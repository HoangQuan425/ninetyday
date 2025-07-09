using OOPDay4.Entity;
using OOPDay4.Repositories;
using OOPDay4.Services;
using OOPDay4.Strategies;

namespace OOPDay4
{
	internal class Program
	{
		static string InputString()
		{
			do
			{
				try
				{
					string input = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(input))
					{
						throw new ArgumentException("Input cannot be null or empty");
					}

					if (double.TryParse(input, out _))
					{
						throw new FormatException("Input cannot be a number");
					}
					return input;
				}
				catch (ArgumentException e)
				{
					Console.WriteLine(e.Message);
				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
			} while (true);
		}
		static string InputId()
		{
			do
			{
				try
				{
					string input = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(input))
					{
						throw new ArgumentException("Input cannot be null or empty");
					}
					return input;
				}
				catch (ArgumentException e)
				{
					Console.WriteLine(e.Message);
				}
			} while (true);
		}
		static int InputNumber()
		{
			do
			{
				try
				{
					int number = int.Parse(Console.ReadLine());
					return number;
				}
				catch (FormatException e)
				{
					Console.WriteLine("please input a interger number");
				}

			} while (true);
		}
		static decimal InputDecimalNumber()
		{
			do
			{
				try
				{
					decimal number = decimal.Parse(Console.ReadLine());
					return number;
				}
				catch (FormatException e)
				{
					Console.WriteLine("please input a interger number");
				}

			} while (true);
		}
		static DateTime InputDate()
		{
			do
			{
				try
				{
					string input = Console.ReadLine();
					DateTime date = DateTime.Parse(input);
					return date;
				}
				catch (FormatException e)
				{
					Console.WriteLine("input incorrect date or press Enter to skip");
				}
			} while (true);

		}
		static DateTime? InputDateCanNullable()
		{
			do
			{
				try
				{
					string input = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(input))
					{
						return null;
					}
					DateTime date = DateTime.Parse(input);
					return date;
				}
				catch (FormatException e)
				{
					Console.WriteLine("input incorrect date or press Enter to skip");
				}
			} while (true);

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, Welcome to EMS!");
			List<Employee> listEmployee = new List<Employee>();
			IEmployeeService service = new EmployeeService(new EmployeeRepository(listEmployee));
			int op;
			do
			{
				Console.WriteLine("=======================================");
				Console.WriteLine("1. Add an employee (Developer/Manager)");
				Console.WriteLine("2. View all employee");
				Console.WriteLine("3. View Employee by Id");
				Console.WriteLine("4. Update Employee");
				Console.WriteLine("5. Delete Employee Data");
				Console.WriteLine("6. Export Employee Data");
				Console.WriteLine("7. Show salary");
				Console.WriteLine("8. Exit");
				Console.WriteLine("Choose option: ");
				op = int.Parse(Console.ReadLine());
				if (op == 8)
				{
					Console.WriteLine("Exit!");
					break;
				}
				switch (op)
				{
					case 1:
						{
							Console.WriteLine("please pick an interger choose add manager(1) or developer(2): ");
							int choose = int.Parse(Console.ReadLine());
							do
							{
								if (choose < 1 || choose > 2)
								{
									Console.WriteLine("pick again must be 1 or 2");
								}
								else
								{
									break;
								}
							} while (true);
							if (choose == 2)
							{
								Console.WriteLine("input Id: ");
								string id = InputId();
								Console.WriteLine("input Name: ");
								string name = InputString();
								Console.WriteLine("input Age: ");
								int age = InputNumber();
								Console.WriteLine("input date of birth: ");
								DateTime birthDate = InputDate();
								Console.WriteLine("input hired date: ");
								DateTime hiredDate = InputDate();
								Console.WriteLine("input leave date: ");
								DateTime? leaveDate = InputDateCanNullable();
								Console.WriteLine("input base salary: ");
								decimal baseS = InputDecimalNumber();
								Console.WriteLine("input allowance: ");
								decimal allowance = InputDecimalNumber();
								Console.WriteLine("input bonus: ");
								decimal bonus = InputDecimalNumber();
								Console.WriteLine("input tax: ");
								decimal tax = InputDecimalNumber();
								Console.WriteLine("input overTime: ");
								decimal overTime = InputDecimalNumber();

								Employee dev = new Developer(id, name, age, DateOnly.FromDateTime(birthDate),
									DateOnly.FromDateTime(hiredDate), leaveDate.HasValue ? DateOnly.FromDateTime(leaveDate.Value) : null, baseS, allowance, bonus, tax, overTime);
								service.Add(dev);
							}
							else if (choose == 1)
							{
								Console.WriteLine("input Id: ");
								string id = InputId();
								Console.WriteLine("input Name: ");
								string name = InputString();
								Console.WriteLine("input Age: ");
								int age = InputNumber();
								Console.WriteLine("input date of birth: ");
								DateTime birthDate = InputDate();
								Console.WriteLine("input hired date: ");
								DateTime hiredDate = InputDate();
								Console.WriteLine("input leave date: ");
								DateTime? leaveDate = InputDateCanNullable();
								Console.WriteLine("input base salary: ");
								decimal baseS = InputDecimalNumber();
								Console.WriteLine("input allowance: ");
								decimal allowance = InputDecimalNumber();
								Console.WriteLine("input bonus: ");
								decimal bonus = InputDecimalNumber();
								Console.WriteLine("input tax: ");
								decimal tax = InputDecimalNumber();
								Console.WriteLine("input overTime: ");
								decimal overTime = InputDecimalNumber();
								Employee manager = new Manager(id, name, age, DateOnly.FromDateTime(birthDate),
									DateOnly.FromDateTime(hiredDate), leaveDate.HasValue ? DateOnly.FromDateTime(leaveDate.Value) : null, baseS, allowance, bonus, tax, overTime);
								service.Add(manager);
							}
							break;
						}
					case 2:
						{
							var result = service.GetAll();
							foreach (Employee e in result)
							{
								e.ShowInfo();
							}
							break;
						}
					case 3:
						{
							//getbyid
							Console.WriteLine("input id to search: ");
							string id = InputId();

							var result = service.GetById(id);
							if (result != null)
							{
								result.ShowInfo();
							}
							else
							{
								Console.WriteLine("Employee not found");
							}
							break;
						}
					case 4:
						{
							//update employee
							Console.WriteLine("input ID: ");
							string id = InputId();
							var employee = service.GetById(id);
							if (employee == null)
							{
								Console.WriteLine("Employee not found");
							}
							else
							{
								Console.WriteLine("input Name: ");
								string name = InputString();
								Console.WriteLine("input Age: ");
								int age = InputNumber();
								Console.WriteLine("input date of birth: ");
								DateTime birthDate = InputDate();
								Console.WriteLine("input hired date: ");
								DateTime hiredDate = InputDate();
								Console.WriteLine("input leave date: ");
								DateTime? leaveDate = InputDateCanNullable();
								Console.WriteLine("input base salary: ");
								decimal baseS = InputDecimalNumber();
								Console.WriteLine("input allowance: ");
								decimal allowance = InputDecimalNumber();
								Console.WriteLine("input bonus: ");
								decimal bonus = InputDecimalNumber();
								Console.WriteLine("input tax: ");
								decimal tax = InputDecimalNumber();
								Console.WriteLine("input overTime: ");
								decimal overTime = InputDecimalNumber();
								if (employee is Developer)
								{
									var dev = new Developer
									(
										employee.Id,
										name,
										age,
										DateOnly.FromDateTime(birthDate),
										DateOnly.FromDateTime(hiredDate),
										leaveDate.HasValue ? DateOnly.FromDateTime(leaveDate.Value) : null,
										baseS,
										allowance,
										 bonus,
										tax,
										overTime
									);
									var result = service.Update(id, dev);
									if (result)
									{
										Console.WriteLine("update success!");
									}
									else
									{
										Console.WriteLine("update fail!");
									}
								}
								else if (employee is Manager)
								{
									var manager = new Manager
									(
										employee.Id,
										name,
										age,
										DateOnly.FromDateTime(birthDate),
										DateOnly.FromDateTime(hiredDate),
										leaveDate.HasValue ? DateOnly.FromDateTime(leaveDate.Value) : null,
										baseS,
										allowance,
										 bonus,
										tax,
										overTime
									);
									var result = service.Update(id, manager);
									if (result)
									{
										Console.WriteLine("update success!");
									}
									else
									{
										Console.WriteLine("update fail!");
									}
								}
								else
								{
									Console.WriteLine("not supported");
								}
							}
							break;
						}
					case 5:
						{
							//delete
							Console.WriteLine("input Id: ");
							string id = InputId();
							var employee = service.GetById(id);
							if (employee == null)
							{
								Console.WriteLine("employee not found");
							}
							else
							{
								var result = service.Delete(id);
								if (result)
								{
									Console.WriteLine("Delete success!");
								}
								else
								{
									Console.WriteLine("Delete fail!");
								}
							}
							break;
						}
					case 6:
						{
							//export
							IExportStrategy strategy = new CSVExport();
							ExportService exService = new ExportService(strategy);
							exService.Export(listEmployee);
							break;
						}
					case 7:
						{
							//Show salary
							Console.WriteLine("input Id");
							var id = InputId();
							var employee = service.GetById(id);
							if (employee == null)
							{
								Console.WriteLine("Employee not found");
							}
							else
							{
								var result = service.CalculateEmployeeSalary(employee.Id);
								Console.WriteLine(result);
							}
							break;
						}
					default:
						{
							Console.WriteLine("You must input correct option");
							break;
						}
				}
			} while (true);
		}
	}
}
