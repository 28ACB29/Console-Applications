using System;
using System.Collections.Generic;
using Utility;

namespace FutureValue
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
			string choice;

			//Added row counter and string array for table
			int rows;

			//Altered table from two dimensional arrray of Strings
			//to ArrayList of String Arrays
			//String[][] table;
			List<string[]> table;
			double monthlyInvestment;
			double interestRate;
			int years;
			double monthlyInterestRate;
			int months;
			double futureValue;

			//Added results string
			string results;
			string[] row;
			string message;

			//Added information string
			string information;
			choice = "y";

			//Added row counter and string array for table
			rows = 0;

			//Altered table from two dimensional arrray of Strings
			//to ArrayList of String Arrays
			//table = new String[10][4];
			table = new List<string[]>(10);

			// perform 1 or more calculations
			while(!choice.Equals("n"))
			{
				// get the input from the user
				//Altered input code to include validation
				//System.Console.Out.Write("Enter monthly investment:   ");
				//monthlyInvestment = sc.nextDouble();
				//System.Console.Out.Write("Enter yearly interest rate: ");
				//interestRate = sc.nextDouble();
				//System.Console.Out.Write("Enter number of years:      ");
				//years = sc.nextInt();

				//Replaced getDoubleWithinRange with getDouble
				//monthlyInvestment = getDoubleWithinRange("Enter monthly investment: ", 0, 1000);
				//interestRate = getDoubleWithinRange("Enter yearly interest rate: ", 0, 30);
				monthlyInvestment = Validator.GetDouble("Enter monthly investment: ", 0, 1000);
				interestRate = Validator.GetDouble("Enter yearly interest rate: ", 0, 30);

				//Replaced getIntWithinRange with getInt
				//years = getIntWithinRange("Enter number of years: ", 0, 100);
				years = Validator.GetInt("Enter number of years: ", 0, 100);

				// convert yearly values to monthly values and initialize future value
				monthlyInterestRate = interestRate / 12 / 100;
				months = years * 12;
				//Altered calculation code to use a function
				//futureValue = 0.0;

				//// use a for loop to calculate the future value
				//for (int i = 1; i <= months; i++)
				//{
				//    futureValue = (futureValue + monthlyInvestment) *
				//    (1 + monthlyInterestRate);
				//}

				//Added FinancialCalculations class resolution
				//futureValue = calculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
				futureValue = FinancialCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);

				//Altered print statement to use a string
				//System.Console.Out.WriteLine("Future value:               "
				//                  + String.Format("{0:C}", futureValue));

				// format the result as a single string
				results = "Monthly investment:\t"
						+ string.Format("{0:C}", monthlyInvestment)
						+ "\n"
						+ "Yearly interest rate:\t"
						+ string.Format("{0:0.0%}", interestRate / 100)
						+ "\n"
						+ "Number of years:\t"
						+ years.ToString()
						+ "\n"
						+ "Future value:\t\t"
						+ string.Format("{0:C}", futureValue)
						+ "\n";

				//Added code to store entries in table
				//Altered code to use ArrayList of String arrays
				//table[rows][0] = String.Format("{0:C}", monthlyInvestment) + " ";
				//table[rows][1] = String.Format("{0:0.0%}", interestRate / 100) + "       ";
				//table[rows][2] = Integer.toString(years) + "   ";
				//table[rows][3] = String.Format("{0:C}", futureValue);
				row = new string[4];
				row[0] = string.Format("{0:C}", monthlyInvestment)
					   + " ";
				row[1] = string.Format("{0:0.0%}", interestRate / 100)
					   + "        ";
				row[2] = years.ToString()
					   + "   ";
				row[3] = string.Format("{0:C}", futureValue);
				table.Insert(rows, row);

				// print the results
				Console.Out.WriteLine();
				Console.Out.WriteLine("FORMATTED RESULTS");
				Console.Out.WriteLine(results);

				// see if the user wants to continue
				Console.Out.Write("Continue? (y/n): ");
				choice = Console.In.ReadLine();
				Console.Out.WriteLine();

				//Added code to increment the row counter
				rows++;
			}
			Console.Out.WriteLine("Future Value Calculations");
			Console.Out.WriteLine();
			message = "Inv/Mo. "
					+ "Rate    "
					+ "Years   "
					+ "Future Value"
					+ "\n";
			Console.Out.WriteLine(message);
			for(int n = 0; n < rows; n++)
			{
				information = table[n][0]
							+ table[n][1]
							+ table[n][2]
							+ table[n][3];
				Console.Out.WriteLine(information);
			}

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
