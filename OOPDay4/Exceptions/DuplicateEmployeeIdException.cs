namespace OOPDay4.Exceptions
{
	public class DuplicateEmployeeIdException : Exception
	{
		public DuplicateEmployeeIdException()
		{
		}

		public DuplicateEmployeeIdException(string? message) : base(message)
		{
		}

		public DuplicateEmployeeIdException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
