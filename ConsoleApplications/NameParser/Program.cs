using System;

namespace NameParser
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
			string input;
			string[] names;
			string message;

			Console.Out.WriteLine("Welcome to the name parser.\n");
			Console.Out.Write("Enter a name: ");
			input = Console.In.ReadLine();
			names = input.Split(new char[] { ' ' });
			message = "";
			if(names.Length < 2)
			{
				Console.Out.Write("Too few names");
			}
			else if(names.Length == 2)
			{
				message = "First Name: " + names[0] + "\n"
						+ "Last Name:  " + names[1] + "\n";
			}
			else if(names.Length == 3)
			{
				message = "First Name:   " + names[0] + "\n"
						+ "Middle Name:  " + names[1] + "\n"
						+ "Last Name:    " + names[2] + "\n";
			}
			else if(names.Length > 3)
			{
				Console.Out.Write("Too many names");
			}
			Console.Out.WriteLine(message);

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
