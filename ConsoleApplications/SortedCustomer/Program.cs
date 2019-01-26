using Data;
using System;

namespace SortedCustomer
{
	public class Program
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Customer[] customers;

			//Added customers that are stored in an array
			customers = new Customer[3];

			//Added code to sort customers by email
			Array.Sort(customers);

			//Added for-each loop to print out all the information
			foreach(Customer customer in customers)
			{
				Console.Out.WriteLine(customer.email);
				Console.Out.WriteLine();
				Console.Out.WriteLine(customer.firstName);
				Console.Out.WriteLine();
				Console.Out.WriteLine(customer.lastName);
				Console.Out.WriteLine();
				Console.Out.WriteLine();
			}

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
