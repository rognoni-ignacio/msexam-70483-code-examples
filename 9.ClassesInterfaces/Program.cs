using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ClassesInterfaces
{
	public interface Interface1
	{
		void Method1();
		void Method2();
	}

	public class Class1 : Interface1
	{
		public void Method1()
		{
			throw new NotImplementedException();
		}

		public void Method2()
		{
			throw new NotImplementedException();
		}
	}

	public class Class2 : Interface1
	{
		public void Method1()
		{
			throw new NotImplementedException();
		}

		public void Method2()
		{
			throw new NotImplementedException();
		}
	}

	public class Class3 : Interface1
	{
		// 
		public void Method1()
		{
			throw new NotImplementedException();
		}

		void Interface1.Method2()
		{
			throw new NotImplementedException();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Method1 - Opcion 3
			Class3 class3_1 = new Class3();
			class3_1.Method1();

			// Method2 - Opcion 4
			Interface1 class3_2 = new Class3();
			class3_2.Method1();
			class3_2.Method2();
		}
	}
}
