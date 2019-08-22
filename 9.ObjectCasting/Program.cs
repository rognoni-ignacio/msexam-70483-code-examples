using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ObjectCasting
{
	class Program
	{
		// Respuesta D. Es posible castear sin error una interface utilizando "as"

		public interface IDataContainer
		{
			string Data { get; set; }
		}

		public class DataContainer : IDataContainer
		{
			public string Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		}

		static void Main(string[] args)
		{
			object obj = new object();
			DoWork(obj);

			DataContainer dataContainer = new DataContainer();
			DoWork(dataContainer);
		}

		static void DoWork(object obj)
		{
			var dataContainer = obj as IDataContainer;
			if (dataContainer != null)
			{
				Console.WriteLine(dataContainer);
			}
		}
	}
}
