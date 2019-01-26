﻿using System;

namespace Utility
{
	public class Validator
	{

		/// <summary>
		/// Copied function from Main
		/// </summary>
		/// <param name="prompt"></param>
		/// <returns></returns>
		public static double GetDouble(string prompt)
		{
			double d;
			bool isValid;
			string input;
			d = 0.0;
			isValid = false;
			while(isValid == false)
			{
				Console.Out.Write(prompt);
				input = Console.In.ReadLine();
				if(double.TryParse(input, out d))
				{
					isValid = true;
				}
				else
				{
					d = 0.0;
					Console.Out.WriteLine("Error! Invalid decimal value. Try again.");
				}
			}
			return d;
		}

		/// <summary>
		/// Copied function from Main
		/// </summary>
		/// <param name="prompt"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double GetDouble(string prompt, double min, double max)
		{
			double d = 0;
			bool isValid = false;
			while(isValid == false)
			{
				d = GetDouble(prompt);

				//Added braces
				if(d <= min)
				{
					Console.Out.WriteLine(
						"Error! Number must be greater than " + min);
				}
				else if(d >= max)
				{
					Console.Out.WriteLine(
						"Error! Number must be less than " + max);
				}
				else
				{
					isValid = true;
				}
			}
			return d;
		}

		/// <summary>
		/// Copied function from Main
		/// </summary>
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
		/// Copied function from Main
		/// </summary>
		/// <param name="prompt"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int GetInt(string prompt, int min, int max)
		{
			int i = 0;
			bool isValid = false;
			while(isValid == false)
			{
				i = GetInt(prompt);

				//Added braces
				if(i <= min)
				{
					Console.Out.WriteLine(
						"Error! Number must be greater than " + min);
				}
				else if(i >= max)
				{
					Console.Out.WriteLine(
						"Error! Number must be less than " + max);
				}
				else
				{
					isValid = true;
				}
			}
			return i;
		}

		/// <summary>
		/// Copied function from Main
		/// </summary>
		/// <param name="prompt"></param>
		/// <returns></returns>
		public static string GetLine(string prompt)
		{
			Console.Out.Write(prompt);

			// read the whole line
			string s = Console.In.ReadLine();
			return s;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prompt"></param>
		/// <returns></returns>
		public static string GetSSN(string prompt)
		{
			string ssn = "";
			string[] numbers;
			ssn = GetString(prompt);
			numbers = ssn.Split(new char[] { '-' });
			if(!(ssn.Length == 11))
			{
				Console.Out.Write("String is not the correct length\n");
				ssn = GetSSN(prompt);
			}
			else if(!ssn.Contains("-"))
			{
				Console.Out.Write("String is does not contain dashes\n");
				ssn = GetSSN(prompt);
			}
			else if(!(numbers[0].Length == 3) && !(numbers[1].Length == 2) && !(numbers[2].Length == 4))
			{
				Console.Out.Write("String is not the correct length\n");
				ssn = GetSSN(prompt);
			}
			return ssn;
		}

		/// <summary>
		/// Copied function from Main
		/// </summary>
		/// <param name="prompt"></param>
		/// <returns></returns>
		public static string GetString(string prompt)
		{
			Console.Out.Write(prompt);

			// read the first string on the line
			string s = Console.In.ReadLine();
			return s;
		}
	}
}
