using Data;
using System;

namespace ProductCloneTest
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
			Product p1;
			Product p2;
			Console.Out.WriteLine("Welcome to the Product Clone Test\n");

			// create a new product
			p1 = new Product();
			p1.code = "java";
			p1.description = "Murach's Beginning Java 2";
			p1.price = 49.50;

			// clone the product
			//Remove redundant cast
			//p2 = (Product) p1.clone();
			p2 = p1.Clone();

			// change a value in the cloned product
			p2.price = 44.50;

			if(p1.price == p2.price)
			{
				Console.Out.WriteLine("FAILURE: The clone method of the Product class is not cloning data.");
			}
			else if(p1.price != p2.price)
			{
				Console.Out.WriteLine("SUCCESS: The clone method of the Product class is cloning data.");
			}
			Console.Out.WriteLine();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
