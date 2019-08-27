using System;
using System.Collections.Generic;
using System.Linq;

namespace BriefMeNow.Q1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Question: https://www.briefmenow.org/microsoft/how-should-you-complete-the-code-39/
			// Response: Where, Any, =>, ==. Se utiliza Any en lugar de Join porque las clases Customer y Orders no tiene una propiedad en comun

			var customers = new List<Customer>
			{
				new Customer
				{
					Orders = new List<Orders>
					{
						new Orders
						{
							OrderDate = DateTime.Now
						},
						new Orders
						{
							OrderDate = DateTime.Now.AddYears(-2)
						},
						new Orders
						{
							OrderDate = DateTime.Now.AddYears(-4)
						},
						new Orders
						{
							OrderDate = DateTime.Parse("27-08-2005")
						},
						new Orders
						{
							OrderDate = DateTime.Parse("26-08-2005")
						}
					}
				},
				new Customer
				{
					Orders = new List<Orders>
					{
						new Orders
						{
							OrderDate = DateTime.Now.AddYears(-4)
						}
					}
				}
			};

			List<Customer> customersWithOrdersIn2005 =
			customers.Where(c => c.Orders.Any(o => o.OrderDate.Year == 2005)).ToList();
		}
	}

	internal class Customer
	{
		public List<Orders> Orders { get; set; }
	}

	internal class Orders
	{
		public DateTime OrderDate { get; set; }
	}
}
