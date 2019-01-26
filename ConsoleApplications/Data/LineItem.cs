namespace Data
{
	public class LineItem
	{
		public Product product;
		public int quantity;
		public double Total
		{
			get
			{
				this.Total = this.quantity * this.product.price;
				return this.Total;
			}
			set
			{
				this.Total = value;
			}
		}

		/// <summary>
		/// Default Constructor
		/// </summary>
		public LineItem()
		{
			this.product = null;
			this.quantity = 0;
			this.Total = 0;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="product"></param>
		/// <param name="quantity"></param>
		public LineItem(Product product, int quantity)
		{
			this.product = product;
			this.quantity = quantity;
			this.Total = this.Total;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string FormattedTotal
		{
			get
			{
				return string.Format("{0:c}", this.Total);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string message;
			message = "Product:  " + this.product + "\n" +
					  "Quantity: " + this.quantity + "\n" +
					  "Total:    " + this.Total + "\n";
			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Object"></param>
		/// <returns></returns>
		public override bool Equals(object Object)
		{
			LineItem lineItem;
			if(Object is LineItem)
			{
				lineItem = (LineItem) Object;
				if(this.product.Equals(lineItem.product) &&
				   this.quantity == lineItem.quantity &&
				   this.Total == lineItem.Total)
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
			hash = 3;
			hash = 19 * hash + (this.product != null ? this.product.GetHashCode() : 0);
			hash = 19 * hash + this.quantity;
			hash = 19 * hash + (int) ((long) (this.Total) ^ ((long) (this.Total) >> 32));
			return hash;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public LineItem Clone()
		{
			LineItem lineItem;
			lineItem = new LineItem();
			lineItem.product = this.product.Clone();
			lineItem.quantity = this.quantity;
			lineItem.Total = this.Total;
			return lineItem;
		}
	}
}
