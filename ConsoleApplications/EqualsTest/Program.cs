using Data;
using System;

namespace EqualsTest
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Product product1;
			Product product2;
			LineItem li1;
			LineItem li2;
			Console.Out.WriteLine("Welcome to the Equals Tester\n");

			//Both variables refer to different objects that store the same data
			product1 = new Product();
			product2 = new Product();

			//Added braces
			if(product1.Equals(product2))
			{
				Console.Out.WriteLine("The equals method of the Product class is comparing data.");
			}
			else
			{
				Console.Out.WriteLine("The equals method of the Product class is comparing references.");
			}

			//Both variables refer to different objects that store the same data
			li1 = new LineItem();
			li1.product = product1;
			li2 = new LineItem();
			li2.product = product2;

			//Added braces
			if(li1.Equals(li2))
			{
				Console.Out.WriteLine("The equals method of the LineItem class is comparing data.");
			}
			else
			{
				Console.Out.WriteLine("The equals method of the LineItem class is comparing references.");
			}

			Console.Out.WriteLine();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
