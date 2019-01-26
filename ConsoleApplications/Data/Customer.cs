using System;

namespace Data
{
	public class Customer : IComparable<Customer>
	{
		public string email;
		public string firstName;
		public string lastName;

		/// <summary>
		/// Default Constructor
		/// </summary>
		private Customer()
		{
			this.email = "";
			this.firstName = "";
			this.lastName = "";
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="email"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		public Customer(string email, string firstName, string lastName)
		{
			this.email = email;
			this.firstName = firstName;
			this.lastName = lastName;
		}

		/// <summary>
		/// Added Comparable interface method
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public int CompareTo(Customer other)
		{
			int result = this.email.CompareTo(other.email);
			return result;
		}
	}
}
