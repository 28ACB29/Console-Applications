using Data;
using System;

namespace LineItemClone
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
			LineItem li1;
			LineItem li2;

			// welcome the user to the program
			Console.Out.WriteLine("Weclome to the Line Item Clone Test");
			Console.Out.WriteLine();

			// create a new product
			p1 = new Product();
			p1.code = "java";
			p1.description = "Murach's Beginning Java 2";
			p1.price = 49.50;

			// create a new line item
			li1 = new LineItem();
			li1.product = p1;
			li1.quantity = 3;

			// clone the line item
			//Removed redundant cast
			//li2 = (LineItem) li1.clone();
			li2 = li1.Clone();

			// change a value in the cloned line item
			// and in the Product object it contains
			li2.quantity = 2;
			li2.product.price = 44.50;

			// print the results
			Console.Out.WriteLine(li1);
			Console.Out.WriteLine(li2);

			Console.Out.WriteLine();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
