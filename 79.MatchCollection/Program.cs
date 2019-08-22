using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _79.MatchCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = TestIfWebsite("http://www.google.com http://toto.com toto.com http://softfluent.com");

			Console.WriteLine(result);
		}

		public static List<string> TestIfWebsite(string url)
		{
			const string pattern = @"http://(www\.)?([^\.]+)\.com";

			List<string> result = new List<string>();

			System.Text.RegularExpressions.MatchCollection myMatches = Regex.Matches(url, pattern);

			// Option D
			foreach (Match currentMatch in myMatches)
			{
				result.Add(currentMatch.Value);

				Console.WriteLine(currentMatch.Value);
			}

			return result;
		}
	}
}
