using System;
using System.Configuration;
using System.Diagnostics;

using HelloDI.Interfaces;
using HelloDI.Classes;

namespace HelloDI
{
	class Program
	{
		static void Main(string[] args)
		{
			// Original DI Example
			IMessageWriter writer = new ConsoleMessageWriter();
			var salutation = new Salutation(writer);
			salutation.Exclaim();

			// Late Binding Example
			var typeName = ConfigurationManager.AppSettings["messageWriter"];
			var type = Type.GetType(typeName, true);
			IMessageWriter lateBindingWriter = (IMessageWriter)Activator.CreateInstance(type);
			lateBindingWriter.Write("HelloDI via Late Binding");

			// Extensibility Example
			IMessageWriter secureMessageWriter = new SecureMessageWriter(new ConsoleMessageWriter());
			secureMessageWriter.Write("HelloDI via Extensibility");

			Console.ReadLine();

			Trace.WriteLine("Force Git to update");
		}
	}
}
