namespace AlternativeOOPDay3
{
	/*interface ICalculate
	{
		double Calculate(double a, double b, string option);
	}
	class Calculator : ICalculate
	{
		public double Calculate(double a, double b, string option)
		{
			switch (option)
			{
				case "+":
					{
						return a + b;
					}
				case "-":
					{
						return a - b;
					}
				case "*":
					{
						return a * b;
					}
				case "/":
					{
						if (b == 0)
						{
							Console.WriteLine("Cannot divide by zero.");
							return 0;
						}
						return a / b;
					}
				case "%":
					{
						return a % b;
					}
				default:
					{
						Console.WriteLine("Invalid operator");
						return 0;
					}
			}
		}
	}
	internal class Program
	{
		static double InputNumber()
		{
			do
			{
				try
				{
					Console.WriteLine("input a number: ");
					double number = double.Parse(Console.ReadLine());
					return number;
				}
				catch (FormatException e) { 
					Console.WriteLine("please input a number");
				}

			} while (true);
		}
		static void Main(string[] args)
		{
			ICalculate cal = new Calculator();
			string option;
			do
			{
				Console.WriteLine("Enter operator (+, -, *, /, %), or 'exit' to quit:");
				option = Console.ReadLine();
				if (option.Equals("exit"))
				{
					break;
				}
				double a= InputNumber();
				double b = InputNumber();
				double result = cal.Calculate(a, b, option);
				Console.WriteLine(result);
			}while (true);
		}
	}*/
	/*interface IShape
	{
		double CalculateArea();
	}
	class Circle : IShape
	{
		private readonly double _radius;
		private const double PI = 3.14159;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double CalculateArea()
		{
			return _radius * _radius * PI;
		}
	}
	class Rectangle : IShape
	{
		private readonly double _width;
		private readonly double _height;

		public Rectangle(double width, double height)
		{
			_width = width;
			_height = height;
		}

		public double CalculateArea()
		{
			return _height * _width;
		}
	}*/
	abstract class Shape
	{
		public abstract double GetArea();
	}
	class Rectangle : Shape
	{
		private readonly double _width;
		private readonly double _height;

		public Rectangle(double width, double height)
		{
			_width = width;
			_height = height;
		}

		public override double GetArea()
		{
			return _width * _height;
		}
	}
	class Square : Rectangle
	{
		public Square(double width, double height) : base(width, height)
		{
			width = height;
		}

		public override double GetArea()
		{
			return base.GetArea();
		}
	}
	internal class Program
	{
		static double InputNumber()
		{
			do
			{
				try
				{
					double number = double.Parse(Console.ReadLine());
					return number;
				}
				catch (FormatException e)
				{
					Console.WriteLine("please input a number");
				}

			} while (true);
		}
		static void Main(string[] args)
		{
			/*string option;
			do
			{
				Console.WriteLine("Choose shape: circle, rectangle, or exit: ");
				option = Console.ReadLine();
				if (option.Equals("exit"))
				{
					break;
				}
				switch (option)
				{
					case "circle":
						{
							Console.WriteLine("input r: ");
							double r = InputNumber();
							IShape shape = new Circle(r);
							double result = shape.CalculateArea();
							Console.WriteLine(Math.Round(result, 2));
							break;
						}
					case "rectangle":
						{
							Console.WriteLine("input width: ");
							double w = InputNumber();
							Console.WriteLine("input height: ");
							double h = InputNumber();
							IShape shape = new Rectangle(w, h);
							double result  = shape.CalculateArea();
							Console.WriteLine(result);
							break;
						}
					default:
						{
							Console.WriteLine("invalid input");
							break;
						}
				}
			} while (true);*/
		}
	}
}
