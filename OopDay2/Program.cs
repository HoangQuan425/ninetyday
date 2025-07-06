namespace OopDay2
{
	class Student
	{
		public string Name { get; private set; }
		public int Age { get; private set; }
		public void SetName(string name)
		{
			this.Name = name;
		}
		public void SetAge(int age)
		{
			this.Age = age;
		}
		public void Introduce()
		{
			Console.WriteLine($"Hi, my name is {Name}, I am {Age} years old.");
		}
	}
	class Animal
	{
		public virtual void Speak()
		{
			Console.WriteLine("gầm gừ");
		}
	}
	class Cat : Animal
	{
		public override void Speak() {
			Console.WriteLine("meo meo");
		}
	}
	class Dog : Animal
	{
		public override void Speak()
		{
			Console.WriteLine("gâu gâu");
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student();
			student.SetAge(23);
			student.SetName("Hoang Quan");
			student.Introduce();
			Animal Dog = new Dog();
			Animal Cat = new Cat();
			Dog.Speak();
			Cat.Speak();
			Console.WriteLine("Hello, World!");
		}
	}
}
