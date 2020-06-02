using System;
using System.Linq;

namespace PlaygroundInterview
{
	public class StringOperations
	{
		public bool IsInputStartWithUppercase(string input)
		{
			if (input == null)
				throw new NullReferenceException();
			if (input == "")
				throw new IndexOutOfRangeException();

			var firstLetter = input.First();


			return true;
		}
	}
}