using System;
using System.Collections.Generic;

namespace Invoice
{
	public class Program
	{

		/// <summary>
		/// Moved decision tree code into a static function
		/// </summary>
		/// <param name="customerType"></param>
		/// <param name="subTotal"></param>
		/// <returns></returns>
		public static double GetDiscountPercent(string customerType, double subTotal)
		{
			double discountPercent;
			discountPercent = 0.0;

			//Added code that took into account customer type
			//Added braces
			if(customerType.Equals("R"))
			{
				if(subTotal < 100)
				{
					discountPercent = 0;
				}
				else if(subTotal >= 100 && subTotal < 250)
				{
					//Altered discountPercent from .1 to .25
					discountPercent = .25;
				}
				else if(subTotal >= 250)
				{
					//Altered discountPercent from .2 to .3
					discountPercent = .3;
				}
			}
			else if(customerType.Equals("C"))
			{
				//Removed if/else statement
				//if (subtotal < 250)
				//  discountPercent = .2
				//else
				//  discountPercent = .3
				discountPercent = .2;
			}
			//Added case T
			else if(customerType.Equals("T"))
			{
				if(subTotal < 500)
				{
					discountPercent = .4;
				}
				else
				{
					discountPercent = .5;
				}
			}
			else
			{

				//Added extra code for subtotals of at least 500
				if(subTotal >= 500)
				{
					discountPercent = .25;
				}
				if(subTotal >= 200)
				{
					discountPercent = .2;
				}
				else if(subTotal >= 100)
				{
					discountPercent = .1;
				}
				else
				{
					discountPercent = 0.0;
				}
			}
			return discountPercent;
		}

		/// <summary>
		/// Moved customer type validation code into a static function
		/// </summary>
		/// <returns></returns>
		public static string GetValidCustomerType()
		{
			//Added new variable for checking validity
			bool isValid;
			string customerType;
			isValid = false;
			customerType = "";
			while(isValid == false)
			{

				// get the input from the user
				//Added case T
				//Moved customer input code into while loop
				Console.Out.Write("Enter customer type (r/c/t): ");
				customerType = Console.In.ReadLine();

				//Moved validation code into while loop
				//Added validation code for customer type
				if(customerType.Equals("r")
				|| customerType.Equals("c")
				|| customerType.Equals("t"))
				{
					isValid = true;
				}
				else
				{
					//Moved customer input code into while loop
					Console.Out.Write("Invalid Customer type, try again");
					// get the input from the user
					//Added case T
					Console.Out.Write("Enter customer type (r/c/t): ");
					customerType = Console.In.ReadLine();
				}
			}
			return customerType;
		}

		/// <summary>
		/// Moved subtotal validation code into a static function
		/// </summary>
		/// <returns></returns>
		public static double GetValidSubtotal()
		{
			//Added new variable for checking validity
			double subtotal;
			bool isValid;
			string input;
			subtotal = 0.0;
			isValid = false;
			while(isValid == false)
			{

				//Moved subtotal validation code into a static function
				Console.Out.Write("Enter subtotal:   ");
				input = Console.In.ReadLine();
				if(double.TryParse(input, out subtotal))
				{
					if(subtotal > 0 && subtotal < 1000)
					{
						isValid = true;
					}
					else
					{
						Console.Out.Write("Out of range");
					}
				}
				else
				{
					Console.Out.Write("Incorrect type of data");
				}
			}
			return subtotal;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

			//Added customer type
			string choice;

			//Added invoice number
			int invoiceNumber;

			//added table
			List<Data.Invoice> table;
			string customerType;
			double subtotal;
			double discountPercent;
			double discountAmount;

			//Added total before tax and sales tax
			double totalBeforeTax;
			double salesTax;
			double invoiceTotal;
			double totalInvoice;
			double totalDiscount;
			double averageInvoice;
			double averageDiscount;

			//Added results string
			string results;
			string message;

			//Added information string
			string information;

			// welcome the user to the program
			Console.Out.WriteLine("Welcome to the Invoice Total Calculator");

			// print a blank line
			Console.Out.WriteLine();

			// perform invoice calculations until choice isn't equal to "y" or "Y"
			choice = "y";

			//Added invoice number
			invoiceNumber = 0;
			discountAmount = 0.0;
			invoiceTotal = 0.0;
			totalInvoice = 0.0;
			totalDiscount = 0.0;

			//added table
			table = new List<Data.Invoice>(10);
			while(choice.Equals("y"))
			{
				customerType = "";
				try
				{
					// get the invoice subtotal from the user
					//Added case T
					//Moved customer type validation code into a static function
					//System.Console.Out.Write("Enter customer type (r/c/t): ");
					//customerType = sc.next();
					customerType = GetValidCustomerType();
				}
				catch(ArgumentException e)
				{
					Console.Out.Write("Incorrect type of data");
				}

				//Moved subtotal input code into try statement
				//subtotal = sc.nextDouble();
				subtotal = 0.0;
				try
				{

					//Moved subtotal input code into try statement
					//Moved subtotal validation code into a static function
					subtotal = GetValidSubtotal();
				}
				catch(ArgumentException e)
				{
					Console.Out.Write("Incorrect type of data");
				}

				//Added invoice object
				Data.Invoice invoice = new Data.Invoice(subtotal, customerType);

				//Add invoice to the array
				table.Insert(invoiceNumber, invoice);

				//Added invoice number increment
				invoiceNumber++;

				// calculate the discount amount and total
				discountPercent = 0.0;

				// Moved decision tree code into a static function
				discountPercent = GetDiscountPercent(customerType, subtotal);
				discountAmount = subtotal * discountPercent;
				totalBeforeTax = subtotal - discountAmount;
				salesTax = totalBeforeTax * .05;
				invoiceTotal = subtotal - discountAmount;
				totalInvoice += invoiceTotal;
				totalDiscount += discountAmount;

				// display the discount amount and total
				//Added Number of invoices, Average invoice, and Average discount
				//Added Sales tax and Invoice total
				//Added formatting
				//Altered message to results
				//message = "Discount percent:   "
				//        + String.Format("{0:0.0%}", discountPercent)
				//        + "\n"
				//        + "Discount amount:    "
				//        + String.Format("{0:C}", discountAmount)
				//        + "\n"
				//        + "Total before tax:   "
				//        + String.Format("{0:C}", totalBeforeTax)
				//        + "\n"
				//        + "Sales tax:          "
				//        + String.Format("{0:C}", salesTax)
				//        + "\n"
				//        + "Invoice total:      "
				//        + String.Format("{0:C}", invoiceTotal)
				//        + "\n";
				//System.Console.Out.WriteLine(message);
				results = "Discount percent:   "
						+ string.Format("{0:0.0%}", discountPercent)
						+ "\n"
						+ "Discount amount:    "
						+ string.Format("{0:C}", discountAmount)
						+ "\n"
						+ "Total before tax:   "
						+ string.Format("{0:C}", totalBeforeTax)
						+ "\n"
						+ "Sales tax:          "
						+ string.Format("{0:C}", salesTax)
						+ "\n"
						+ "Invoice total:      "
						+ string.Format("{0:C}", invoiceTotal)
						+ "\n";
				Console.Out.WriteLine(results);

				// see if the user wants to continue
				Console.Out.Write("Continue? (y/n): ");
				choice = Console.In.ReadLine();
				Console.Out.WriteLine();
			}

			//Added code to display Number of invoices, Average invoice, and Average discount
			averageInvoice = totalInvoice / invoiceNumber;
			averageDiscount = totalDiscount / invoiceNumber;
			message = "Number of invoices: "
					+ invoiceNumber
					+ "\n"
					+ "Average invoice:    "
					+ string.Format("{0:C}", averageInvoice)
					+ "\n"
					+ "Average discount:   "
					+ string.Format("{0:C}", averageDiscount)
					+ "\n";
			Console.Out.WriteLine(message);
			for(int i = 0; i < table.Count; i++)
			{
				information = table[i].GetInvoice();
				Console.Out.WriteLine(i + 1);
				Console.Out.WriteLine(information);
				Console.Out.WriteLine();
			}

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
