using System;

namespace CustomerType
{
	public class Program
	{

		public enum CustomerType
		{
			college, retail, trade
		};

		public const double college = 0.20;

		public const double retail = 0.10;

		public const double trade = 0.30;

		/// <summary>
		/// a method that accepts a CustomerType enumeration
		/// Added static method to compute discount percent
		/// </summary>
		/// <param name="customertype"></param>
		/// <returns></returns>
		static public double GetDiscountPercent(CustomerType customertype)
		{
			double discountpercent = 0.0;
			switch(customertype)
			{
				case CustomerType.college:
					discountpercent = college;
					break;
				case CustomerType.retail:
					discountpercent = retail;
					break;
				case CustomerType.trade:
					discountpercent = trade;
					break;
				default:
					break;
			}
			return discountpercent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			CustomerType College;
			CustomerType Retail;
			CustomerType Trade;
			double collegeDiscount;
			double retailDiscount;
			double tradeDiscount;
			string message;

			// display a welcome message
			Console.Out.WriteLine("Welcome to the Customer Type Test application\n");

			// get and display the discount percent for a customer type
			//Added several CustomerType variables
			College = CustomerType.college;
			Retail = CustomerType.retail;
			Trade = CustomerType.trade;

			//Added several variables to hold the discount percentages
			collegeDiscount = GetDiscountPercent(College);
			retailDiscount = GetDiscountPercent(Retail);
			tradeDiscount = GetDiscountPercent(Trade);

			//Added code to display customer discounts
			message = "College Discount: " + collegeDiscount + "\n"
					+ "Retail Discount: " + retailDiscount + "\n"
					+ "Trade Discount: " + tradeDiscount + "\n";
			Console.Out.WriteLine(message);

			// display the value of the ToString method of a customer type
			//
			message = College.ToString() + "\n"
					+ Retail.ToString() + "\n"
					+ Trade.ToString() + "\n";
			Console.Out.WriteLine(message);

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
