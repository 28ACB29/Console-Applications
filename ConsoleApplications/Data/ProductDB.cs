using System;

namespace Data
{
	public class ProductDB
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns></returns>
		public static Product GetProduct(string productCode)
		{
			Product product;
			// In a more realistic application, this code would
			// get the data for the product from a file or database
			// For now, this code just uses if/else statements
			// to return the correct product data

			// create the Product object
			product = new Product();

			// fill the Product object with data
			product.code = productCode;
			if(productCode.Equals("java", StringComparison.InvariantCultureIgnoreCase))
			{
				product.description = "Murach's Beginning Java 2";
				product.price = 49.50;
			}
			else if(productCode.Equals("jsps", StringComparison.InvariantCultureIgnoreCase))
			{
				product.description = "Murach's Java Servlets and JSP";
				product.price = 49.50;
			}
			else if(productCode.Equals("mcb2", StringComparison.InvariantCultureIgnoreCase))
			{
				product.description = "Murach's Mainframe COBOL";
				product.price = 59.50;
			}
			else if(productCode.Equals("txtp", StringComparison.InvariantCultureIgnoreCase))
			{
				product.description = "TextPad";
				product.price = 20.00;
			}
			else
			{
				product.description = "Unknown";
			}
			return product;
		}
	}
}
