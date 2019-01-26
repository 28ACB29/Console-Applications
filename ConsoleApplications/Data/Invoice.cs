using System;

namespace Data
{
	public class Invoice
	{

		//Added constant
		public const double taxRate = .05;

		//Moved variables from Main
		public double subtotal;
		public string customerType;
		public double discountPercent;
		public double discountAmount;

		//Added total before tax and sales tax
		private double totalBeforeTax;
		private double salesTax;
		public double total;

		/// <summary>
		/// Moved initialization code from getDiscountPercent to constructor
		/// </summary>
		/// <param name="subTotal"></param>
		/// <param name="customerType"></param>
		public Invoice(double subTotal, string customerType)
		{
			this.customerType = customerType;
			this.discountPercent = 0.0;

			//Added braces
			if(customerType.Equals("r", StringComparison.InvariantCultureIgnoreCase))
			{
				if(subTotal >= 500)
				{
					this.discountPercent = .2;
				}
				else if(subTotal >= 250 && subTotal < 500)
				{
					this.discountPercent = .15;
				}
				else if(subTotal >= 100 && subTotal < 500)
				{
					this.discountPercent = .1;
				}
				else if(subTotal < 100)
				{
					this.discountPercent = .0;
				}
			}
			else if(customerType.Equals("c", StringComparison.InvariantCultureIgnoreCase))
			{
				this.discountPercent = .2;
			}
			else
			{
				this.discountPercent = .05;
			}

			//Moved rest of code from Main
			this.discountAmount = subTotal * this.discountPercent;
			this.totalBeforeTax = subTotal - this.discountAmount;
			this.salesTax = this.totalBeforeTax * taxRate;
			this.total = subTotal - this.discountAmount;
		}

		/// <summary>
		/// Copied code from Main
		/// </summary>
		/// <param name="subTotal"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public double GetDiscountPercent(double subTotal, string type)
		{
			this.discountPercent = 0.0;

			//Added code that took into account customer type
			//Added braces
			if(this.customerType.Equals("R", StringComparison.InvariantCultureIgnoreCase))
			{
				if(subTotal < 100)
				{
					this.discountPercent = 0;
				}
				else if(subTotal >= 100 && subTotal < 250)
				{

					//Altered discountPercent from .1 to .25
					this.discountPercent = .25;
				}
				else if(subTotal >= 250)
				{

					//Altered discountPercent from .2 to .3
					this.discountPercent = .3;
				}
			}
			else if(this.customerType.Equals("C", StringComparison.InvariantCultureIgnoreCase))
			{

				//Removed if/else statement
				//if (subtotal < 250)
				//  discountPercent = .2
				//else
				//  discountPercent = .3
				this.discountPercent = .2;
			}
			//Added case T
			else if(this.customerType.Equals("T", StringComparison.InvariantCultureIgnoreCase))
			{
				if(subTotal < 500)
				{
					this.discountPercent = .4;
				}
				else
				{
					this.discountPercent = .5;
				}
			}
			else
			{

				//Added extra code for subtotals of at least 500
				if(subTotal >= 500)
				{
					this.discountPercent = .25;
				}
				if(subTotal >= 200)
				{
					this.discountPercent = .2;
				}
				else if(subTotal >= 100)
				{
					this.discountPercent = .1;
				}
				else
				{
					this.discountPercent = 0.0;
				}
			}
			return this.discountPercent;
		}

		/// <summary>
		/// Moved formatting and display code from Main
		/// </summary>
		/// <returns></returns>
		public string GetInvoice()
		{
			string formattedSubtotal;
			string formattedCustomerType;
			string formattedDiscountPercent;
			string formattedDiscountAmount;
			string formattedTotalBeforeTax;
			string formattedTotal;
			string formattedSalesTax;
			string message;

			// format the values
			formattedSubtotal = string.Format("{0:C}", this.subtotal);

			//Added braces
			if(this.customerType.Equals("r", StringComparison.InvariantCultureIgnoreCase))
			{
				formattedCustomerType = "Retail";
			}
			else if(this.customerType.Equals("c", StringComparison.InvariantCultureIgnoreCase))
			{
				formattedCustomerType = "College";
			}
			else if(this.customerType.Equals("t", StringComparison.InvariantCultureIgnoreCase))
			{
				formattedCustomerType = "Trade";
			}
			else
			{
				formattedCustomerType = "";
			}
			formattedDiscountPercent = string.Format("{0:0.0%}", this.discountPercent);
			formattedDiscountAmount = string.Format("{0:C}", this.discountAmount);
			formattedTotal = string.Format("{0:C}", this.total);
			formattedTotalBeforeTax = string.Format("{0:C}", this.totalBeforeTax);
			formattedSalesTax = string.Format("{0:C}", this.salesTax);

			// display the discount amount and total
			//Added Number of invoices, Average invoice, and Average discount
			//Added Sales tax and Invoice total
			//Added formatting
			message = "Subtotal:         "
					+ formattedSubtotal
					+ "\n"
					+ "Customer type:    "
					+ formattedCustomerType
					+ "\n"
					+ "Discount percent: "
					+ formattedDiscountPercent
					+ "\n"
					+ "Discount amount:  "
					+ formattedDiscountAmount
					+ "\n"
					+ "Total before tax: "
					+ formattedTotalBeforeTax
					+ "\n"
					+ "Sales tax:        "
					+ formattedSalesTax
					+ "\n"
					+ "Invoice total:    "
					+ formattedTotal
					+ "\n";
			return message;
		}
	}
}
