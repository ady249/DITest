using System;
using System.Diagnostics;

using HelloDI.Classes;
using HelloDI.Interfaces;

using NUnit.Framework;
using NSubstitute;

namespace HelloDITests
{
	[TestFixture]
	public class Testing
	{
		[Test, TestCaseSource("TestCases")]
		public void ExclaimWillWriteCorrectMessageToMessageWriter(string message)
		{
			var mockWriter = Substitute.For<IMessageWriter>();
			var salutation = new Salutation(mockWriter);
			salutation.Exclaim();

			mockWriter.Received().Write(message);

			Trace.WriteLine(String.Format("Testing Output in Unit Tests for {0}", message));
		}

		static string[] TestCases = 
		{
			"Hello DI!",
			"hello di",
			"123ABC"
		};
	}
}
