using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FlagsAttribute
{
	class Program
	{
		// Respuestas Yes, Yes, No. FlagsAttribute permite concatenar los roles y sin el atributo se sumarian los valores

		[System.FlagsAttribute()]
		public enum Group
		{
			Users = 1,
			Supervisors = 2,
			Managers = 4,
			Administrators = 8
		}

		static void Main(string[] args)
		{
			var user = new User();
			user.UserGroup = Group.Administrators;

			Console.WriteLine(user);

			var test1 = user.UserGroup == Group.Administrators;

			Console.WriteLine(test1);

			var test2 = user.UserGroup < Group.Administrators;

			Console.WriteLine(test2);

			user.UserGroup = Group.Supervisors;
			var test3 = user.UserGroup |= Group.Administrators;

			Console.WriteLine(test3);
		}

		public class User
		{
			public Group UserGroup { get; set; }
		}
	}
}
