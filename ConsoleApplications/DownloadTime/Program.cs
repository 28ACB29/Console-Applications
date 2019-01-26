using System;

namespace DownloadTime
{
	public class Program
	{
		public const int mega = 1024;
		public const double modemSpeed = 5.2;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			double fileSize;
			string choice;
			int time;
			int hours;
			int minutes;
			int seconds;
			string message;

			// welcome the user to the program
			Console.Out.WriteLine("Welcome to the Download time Estimator");
			Console.Out.WriteLine("This program calculates how long it will take to download a file with a 56K analog modem");

			// print a blank line
			Console.Out.WriteLine();
			Console.Out.WriteLine("Enter file size (MB): ");

			// print a blank line
			Console.Out.WriteLine();

			fileSize = double.Parse(Console.In.ReadLine());

			choice = "y";

			//Added code to ake sure only "n" or "N" terminates the loop
			while(choice.Equals("y", StringComparison.InvariantCultureIgnoreCase))
			{

				// calculate the discount amount and invoice total
				//Cast to int
				time = (int) (fileSize * mega / modemSpeed);
				hours = time / 3600;
				minutes = (time - hours * 3600) / 60;
				seconds = time - (hours * 3600 + minutes * 60);

				// get the currency and percent formatter objects
				//Removed objects
				// display the results
				message = "A 56K modem will take "
						+ hours + " hours "
						+ minutes + " minutes "
						+ seconds + " seconds";
				Console.Out.WriteLine(message);

				// see if the user wants to continue
				Console.Out.Write("Continue? (y/n): ");
				choice = Console.In.ReadLine();
				Console.Out.WriteLine();
			}

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
