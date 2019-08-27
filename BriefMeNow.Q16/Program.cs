using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefMeNow.Q16
{
	class Program
	{
		static void Main(string[] args)
		{
			// Question: https://www.briefmenow.org/microsoft/you-need-to-ensure-that-new-instances-of-connection-can/
			// Answer: Agregar "protected Connection() { }" a la clase "Connection"

			var connection1 = Connection.Create();
			//var connection2 = new Connection();
		}

		public class Connection
		{
			protected Connection() { }

			public static Connection Create()
			{
				return new Connection();
			}
		}

		public class Test : Connection { }
	}
}
