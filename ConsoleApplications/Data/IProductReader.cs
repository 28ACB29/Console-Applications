using System.Collections.Generic;

namespace Data
{
	public interface IProductReader
	{
		Product GetProduct(string code);
		List<Product> GetProducts();
		string GetProductsString();
	}
}
