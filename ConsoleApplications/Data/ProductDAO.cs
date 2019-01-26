using System.Collections.Generic;

namespace Data
{
	// all static constants from the DAOConstants interface
	public abstract class ProductDAO : ProductConstants, IProductReader, IProductWriter
	{

		// all methods from the IProductReader interface
		public abstract Product GetProduct(string code);
		public abstract List<Product> GetProducts();
		public abstract string GetProductsString();

		// all methods from the IProductWriter interface
		public abstract bool AddProduct(Product p);
		public abstract bool DeleteProduct(Product p);
		public abstract bool UpdateProduct(Product p);
		
		public abstract void ListProducts();
	}
}
