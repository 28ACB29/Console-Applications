using Data;
using System;

namespace GenericStack
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
			GenericStack<string> fruit;
			fruit = new GenericStack<string>();

			fruit.Push("Apples");
			fruit.Push("Oranges");
			fruit.Push("Bananas");
			Console.Out.WriteLine("The stack contains " + fruit.Size() + " items\n");

			fruit.Peek();
			Console.Out.WriteLine("The stack contains " + fruit.Size() + " items\n");

			fruit.Pop();
			fruit.Pop();
			fruit.Pop();
			Console.Out.WriteLine("The stack contains " + fruit.Size() + " items\n");

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
