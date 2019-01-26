namespace Data
{
	public interface IProductWriter
	{
		bool AddProduct(Product p);
		bool DeleteProduct(Product p);
		bool UpdateProduct(Product p);
	}
}
