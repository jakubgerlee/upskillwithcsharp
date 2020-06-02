using System;

namespace PlaygroundInterview
{
	class Program
	{
		static void Main(string[] args)
		{
			var stringOperations = new StringOperations();
			stringOperations.IsInputStartWithUppercase("Ada");
			stringOperations.IsInputStartWithUppercase("ada");

			Console.ReadKey();
		}
	}
}

