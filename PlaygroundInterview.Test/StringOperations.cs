using System;
using NUnit.Framework;

namespace PlaygroundInterview.Test
{
	public class StringOperations
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void IsInputStartWithUppercase_ThrowNullReferenceException_InputIsNull()
		{
			string input = null;
			var subject = new PlaygroundInterview.StringOperations();

			Assert.Throws<NullReferenceException>(() => subject.IsInputStartWithUppercase(input));
		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsEmpty()
		{
			var input = "";
			var subject = new PlaygroundInterview.StringOperations();

			Assert.Throws<NullReferenceException>(() => subject.IsInputStartWithUppercase(input));

		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsWithLowercase()
		{
			var input = "test";
			var subject = new PlaygroundInterview.StringOperations();

			var result = subject.IsInputStartWithUppercase(input);

			Assert.False(result);
		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsWithCapitalLetter()
		{
			var input = "Test";
			var subject = new PlaygroundInterview.StringOperations();

			var result = subject.IsInputStartWithUppercase(input);

			Assert.False(result);
		}
	}
}