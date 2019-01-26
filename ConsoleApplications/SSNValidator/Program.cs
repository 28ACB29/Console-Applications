using System;
using Utility;

namespace SSNValidator
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
			string ssn;

			//Removed getLine method in favor of getSSN method
			ssn = Validator.GetSSN("Enter a Social Security Number: ");
			Console.Out.WriteLine("You entered: " + ssn);

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
