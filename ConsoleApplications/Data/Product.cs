namespace Data
{
	public class Product : IDisplayable
	{
		public string code;
		public string description;
		public double price;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public Product()
		{
			this.code = "";
			this.description = "";
			this.price = 0;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="code"></param>
		/// <param name="description"></param>
		/// <param name="price"></param>
		public Product(string code, string description, double price)
		{
			this.code = code;
			this.description = description;
			this.price = price;
		}

		/// <summary>
		/// 
		/// </summary>
		public string FormattedPrice
		{
			get
			{
				return string.Format("{0:c}", this.price);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string message;
			message = "Code:        " + this.code + "\n" +
					  "Description: " + this.description + "\n" +
					  "Price:       " + this.FormattedPrice + "\n";
			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Object"></param>
		/// <returns></returns>
		public override bool Equals(object Object)
		{
			Product product;
			if(Object is Product)
			{
				product = (Product) Object;
				if(this.code.Equals(product.code) &&
				   this.description.Equals(product.description) &&
				   this.price == product.price)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			int hash;
			hash = 7;
			hash = 67 * hash + (this.code != null ? this.code.GetHashCode() : 0);
			hash = 67 * hash + (this.description != null ? this.description.GetHashCode() : 0);
			hash = 67 * hash + (int) ((long) (this.price) ^ ((long) (this.price) >> 32));
			return hash;
		}

		/// <summary>
		/// Added IDisplayable interface method
		/// </summary>
		/// <returns></returns>
		public string GetDisplayText()
		{
			string message;
			message = "Code: " + this.code + "\n" +
					  "Description: " + this.description + "\n" +
					  "Price: " + this.FormattedPrice + "\n";
			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Product Clone()
		{
			Product p;
			p = new Product();
			p.code = this.code;
			p.description = this.description;
			p.price = this.price;
			return p;
		}
	}
}
