using System;

namespace TestScore
{
	public class Program
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name=""></param>
		/// <param name="prompt"></param>
		/// <returns></returns>
		public static int GetInt(string prompt)
		{
			int i;
			bool isValid;
			string input;
			i = 0;
			isValid = false;
			while(isValid == false)
			{
				Console.Out.Write(prompt);
				input = Console.In.ReadLine();
				if(int.TryParse(input, out i))
				{
					isValid = true;
				}
				else
				{
					i = 0;
					Console.Out.WriteLine("Error! Invalid integer value. Try again.");
				}
			}
			return i;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name=""></param>
		/// <param name="prompt"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int GetIntWithinRange(string prompt, int min, int max)
		{
			int i;
			bool isValid;
			i = 0;
			isValid = false;
			while(isValid == false)
			{
				i = GetInt(prompt);
				//Added braces
				if(i < min)
				{
					Console.Out.WriteLine("Error! Number must be greater than " + min + ".");
				}
				else if(i > max)
				{
					Console.Out.WriteLine("Error! Number must be less than " + max + ".");
				}
				else
				{
					isValid = true;
				}
			}
			return i;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			int scoreCount;
			int testScore;

			//Altered scoreTotal from double to int
			int scoreTotal;

			//Added min and max score variables
			int minScore;
			int maxScore;

			//Added new variable to keep track of the number of scores desired
			int numDesired;
			string choice;
			double averageScore;

			string message;

			// display operational messages
			Console.Out.WriteLine("Please enter test scores that range from 0 to 100.");
			Console.Out.WriteLine("To end the program enter 999.");

			// print a blank line
			Console.Out.WriteLine();

			// initialize variables and create a Scanner object
			scoreCount = 0;
			testScore = 0;

			//Altered scoreTotal from double to int
			scoreTotal = 0;

			//Added min and max score variables
			minScore = 0;
			maxScore = 0;

			//Added new variable to keep track of the number of scores desired
			numDesired = 0;
			choice = "";

			// get a series of test scores from the user
			//Altered while loop to do-while
			//while (testScore <= 100)
			do
			{

				//Added code to get the number of test scores
				//Removed original code and replaced it with static method
				//System.Console.Out.Write("Enter the number of test scores to be entered: ");
				//numDesired = sc.nextInt();
				numDesired = GetIntWithinRange("Enter the number of test scores to be entered: ", 5, 35);

				//Added for loop
				for(; scoreCount < numDesired;)
				{

					// get the input from the user
					//Removed original code and replaced it with static method
					//System.Console.Out.Write("Enter score: ");
					//testScore = sc.nextInt();
					testScore = GetIntWithinRange("Enter score: ", 1, 100);

					// accumulate score count and score total
					if(testScore <= 100)
					{
						//Altered code to use += operator
						//scoreCount = scoreCount + 1;
						//scoreTotal = scoreTotal + testScore;
						scoreCount += 1;
						scoreTotal += testScore;

						//Added max and min score code
						minScore = Math.Min(testScore, minScore);
						maxScore = Math.Max(testScore, maxScore);
					}

					//Added code to make sure only 999 terminates the loop
					else
					{
						if(testScore != 999)
						{
							Console.Out.WriteLine("Invalid entry, not counted");
							testScore = 0;
						}
					}

					//Added prompt for more test scores
					Console.Out.WriteLine("Enter more test scores: ");
				}

				//Moved code for calculation, formatting, and display
				//into the while loop
				// display the score count, score total, and average score
				//Added casting code so that they are both doubles
				//averageScore = (double) scoreTotal / (double) scoreCount;
				//Removed casting code and replaced it with decimal division
				averageScore = (double) ((decimal) scoreTotal / (decimal) scoreCount);

				message = "\n"
						+ "Score count:   "
						+ scoreCount
						+ "\n"
						+ "Score total:   "
						+ scoreTotal
						+ "\n"

						//Altered code to add rounding display code
						//+ "Average score: " + averageScore + "\n"
						+ "Average score: "
						+ string.Format("{0:0.0}", averageScore)
						+ "\n"

						//Added min and max score display code
						+ "Minimum score: "
						+ minScore
						+ "\n"
						+ "Maximum Score: "
						+ maxScore
						+ "\n";

				// print a blank line
				Console.Out.WriteLine();

				//Added prompt message
				Console.Out.WriteLine("Enter more test scoes? (y/n):");
				Console.Out.WriteLine(message);

				//Added code to get choice
				choice = Console.In.ReadLine();
			}
			while(choice.Equals("y"));

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
