using Data;
using System;

namespace DisplayableTest
{
	public class Program
	{

		/// <summary>
		/// Added static method
		/// </summary>
		/// <param name="displayable"></param>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string DisplayMultiple(IDisplayable displayable, int number)
		{
			string output;
			output = "";
			for(int i = 0; i < number; i++)
			{
				output += displayable.GetDisplayText() + "\n";
			}
			return output;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			IDisplayable employee;
			IDisplayable product;
			Console.Out.WriteLine("Welcome to the Displayable Test application\n");

			// create an Employee object
			//Added Employee object as per specification
			employee = new Employee(1, "Baroi", "Arthur", 30000.00);

			// display the employee information
			Console.Out.WriteLine(DisplayMultiple(employee, 1));

			Console.Out.WriteLine();

			// create a Product object
			//Added Product object as per specification
			product = new Product("NI", "No Idea", 15.98);

			// display the product information
			Console.Out.WriteLine(DisplayMultiple(product, 2));

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
