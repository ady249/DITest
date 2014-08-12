using System;

using HelloDI.Interfaces;

namespace HelloDI.Classes
{
	public class ConsoleMessageWriter : IMessageWriter
	{
		public void Write(string message)
		{
			Console.WriteLine(message);
		}
	}
}
