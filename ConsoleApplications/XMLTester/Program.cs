using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Utility;

namespace XMLTester
{
	public class Program
	{

		public static string productsFilename = "./products.xml";

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<Product> ReadProducts()
		{
			List<Product> products;
			Product p;
			XmlTextReader reader;
			XmlNodeType nodeType;
			string attributeName;
			string code;
			string description;
			double price;

			// add code that reads the XML document from the products.xml file
			//Added code
			products = new List<Product>();
			p = null;
			try
			{
				reader = new XmlTextReader(new StreamReader(productsFilename));
				while(reader.Read())
				{
					nodeType = reader.NodeType;
					if(nodeType == XmlNodeType.EndElement)
					{
						while(reader.MoveToNextAttribute())
						{
							attributeName = reader.Name;
							if(attributeName.Equals("Code"))
							{
								p = new Product();
								code = reader.Value;
								p.code = code;
							}
							else if(attributeName.Equals("Description"))
							{
								description = reader.Value;
								p.description = description;
							}
							else if(attributeName.Equals("Price"))
							{
								price = double.Parse(reader.Value);
								p.price = price;
							}
						}
					}
					else if(nodeType == XmlNodeType.EndElement)
					{
						products.Add(p);
					}
				}
			}
			catch(FileNotFoundException ex)
			{
				;
			}
			catch(XmlException ex)
			{
				;
			}
			return products;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="products"></param>
		public static void WriteProducts(List<Product> products)
		{
			// add code that writes the XML document to the products.xml file
			//Added code
			XmlTextWriter writer;
			try
			{
				writer = new XmlTextWriter(new StreamWriter(productsFilename));
				writer.WriteStartElement("Products");

				foreach(Product product in products)
				{
					writer.WriteStartElement("Product");
					writer.WriteAttributeString("Code", product.code);

					writer.WriteStartElement("Description");
					writer.WriteString(product.description);
					writer.WriteEndElement();

					writer.WriteStartElement("Price");
					writer.WriteString(product.price.ToString());
					writer.WriteEndElement();

					writer.WriteEndElement();
				}
				writer.WriteEndElement();
			}
			catch(IOException ex)
			{
				;
			}
			catch(XmlException ex)
			{
				;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="products"></param>
		public static void PrintProducts(List<Product> products)
		{
			foreach(Product p in products)
			{
				PrintProduct(p);
			}
			Console.Out.WriteLine();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="p"></param>
		public static void PrintProduct(Product p)
		{
			string productString;
			productString = StringUtils.PadWithSpaces(p.code, 8) +
							StringUtils.PadWithSpaces(p.description, 44) +
							p.FormattedPrice;

			Console.Out.WriteLine(productString);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.Out.WriteLine("Hello World!");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
