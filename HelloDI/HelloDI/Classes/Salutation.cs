using System;

using HelloDI.Interfaces;

namespace HelloDI.Classes
{
	public class Salutation
	{
		private readonly IMessageWriter writer;

		public Salutation(IMessageWriter writer) // Constructor Injection
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}

			this.writer = writer;
		}

		public void Exclaim()
		{
			this.writer.Write("Hello DI!");
		}
	}
}
