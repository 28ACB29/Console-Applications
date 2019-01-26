using System;
using System.Globalization;
using Utility;

namespace AgeCalculator
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
			DateTime today;
			int birthMonth;
			int birthDay;
			int birthYear;
			DateTime birthDate;
			string message;

			today = new DateTime();

			//Get the user's birthdate
			Console.Out.WriteLine("Welcome to the age calculator.");
			birthMonth = Validator.GetInt("Enter the month you were born (1 to 12): ", 0, 13);
			birthDay = Validator.GetInt("Enter the day of the month you were born: ", 0, 32);

			birthYear = Validator.GetInt("Enter the year you were born (four digits): ", today.Year - 110, today.Year + 1);

			//Added code to set birthdate
			birthDate = new DateTime(birthYear, birthMonth, birthDay);

			//Added code to print birthdate
			message = "Birth date is: " + birthDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
			Console.Out.WriteLine(message);
			message = "Current date is: " + today.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
			Console.Out.WriteLine(message);
			message = "Your age is: " + (today.Year - birthDate.Year);
			Console.Out.WriteLine(message);

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
