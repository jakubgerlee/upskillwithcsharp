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
			var subject = new PlaygroundInterview.StringOperations();

			Assert.Throws<NullReferenceException>(() => subject.IsInputStartWithUppercase(null));
		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsEmpty()
		{
			const string input = "";
			var subject = new PlaygroundInterview.StringOperations();

			Assert.Throws<IndexOutOfRangeException>(() => subject.IsInputStartWithUppercase(input));

		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsWithLowercase()
		{
			const string input = "test";
			var subject = new PlaygroundInterview.StringOperations();

			var result = subject.IsInputStartWithUppercase(input);

			Assert.That(result, Is.False);
		}

		[Test]
		public void IsInputStartWithUppercase_ThrowIndexOutOfRange_InputIsWithCapitalLetter()
		{
			const string input = "Test";
			var subject = new PlaygroundInterview.StringOperations();

			var result = subject.IsInputStartWithUppercase(input);

			Assert.That(result, Is.True);
		}
	}
}