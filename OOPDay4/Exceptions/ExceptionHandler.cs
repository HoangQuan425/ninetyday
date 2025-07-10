namespace OOPDay4.Exceptions
{
	public class ExceptionHandler 
	{
		public void Handle(Exception ex)
		{
			switch (ex)
			{
				case EmployeeNotFoundException enfe:
					{
						Console.WriteLine(enfe.Message);
						break;
					}
				case DuplicateEmployeeIdException deie:
					{
						Console.WriteLine(deie.Message);
						break;
					}
				case ArgumentNullException ane:
					{
						Console.WriteLine(ane.Message);
						break;
					}
				default:
					{
						Console.WriteLine("Unknow error");
						break;
					}
			}
		}
	}
}