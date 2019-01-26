using System;

namespace ArrayTest
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
			int[] values;
			Random random;
			int value;
			int sum;

			//Added array and dummy variable
			values = new int[99];
			random = new Random();
			value = 0;
			sum = 0;

			//Added for loop to store random numbers
			for(int n = 0; n < 99; n++)
			{
				value = (int) (100 * random.NextDouble());
				values[n] = value;
			}

			//Added for loop
			Console.Out.WriteLine("Array Members:");
			foreach(int member in values)
			{
				Console.Out.WriteLine(member);
				sum += member;
			}

			//Added average variable and code to print it out
			double average = (double) (sum / values.Length);
			Console.Out.WriteLine("Array Average:");
			Console.Out.Write(average);
			Console.Out.WriteLine();

			//Added code to sort the array
			Array.Sort(values);

			//Added code to print the median of the array
			Console.Out.WriteLine("Array Median:");
			Console.Out.Write(values[50]);
			Console.Out.WriteLine();

			//Added for loop to print out every 9th value
			Console.Out.WriteLine("Every 9th Value:");
			for(int n = 0; n < 99; n++)
			{
				if(n % 9 == 0)
				{
					Console.Out.Write(values[n] + " ");
				}
			}
			Console.Out.WriteLine();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
