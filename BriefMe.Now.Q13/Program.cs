using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefMe.Now.Q13
{
	class Program
	{
		static void Main(string[] args)
		{
			// Question: https://www.briefmenow.org/microsoft/which-code-segments-should-you-include-in-target-1-tar-11/


			try
			{
				DoWork();
			}
			catch(ContosoValidationException ex)
			{
				Log(ex);
			}
			catch (ContosoDbException ex)
			{
				Log(ex);
			}
			catch (ContosoException ex)
			{
				Log(ex);
			}
		}

		private static void Log(ContosoException ex)
		{
			throw new NotImplementedException();
		}

		private static void Log(ContosoDbException ex)
		{
			throw new NotImplementedException();
		}

		private static void Log(ContosoValidationException ex)
		{
			throw new NotImplementedException();
		}

		private static void DoWork()
		{
			throw new NotImplementedException();
		}

		public class ContosoException : Exception { }
		public class ContosoDbException : ContosoException { }
		public class ContosoValidationException : ContosoException { }
	}
}
