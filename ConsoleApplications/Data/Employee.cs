namespace Data
{
	public class Employee : IDisplayable
	{
		public int department;
		public string firstName;
		public string lastName;
		public double salary;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="department"></param>
		/// <param name="lastName"></param>
		/// <param name="firstName"></param>
		/// <param name="salary"></param>
		public Employee(int department, string lastName, string firstName, double salary)
		{
			this.department = department;
			this.lastName = lastName;
			this.firstName = firstName;
			this.salary = salary;
		}

		/// <summary>
		/// the department name
		/// </summary>
		public string DepartmentName
		{
			get
			{
				string departmentName;
				departmentName = "";
				if(this.department == DepartmentConstants.ADMIN)
				{
					departmentName = "ADMIN";
				}
				else if(this.department == DepartmentConstants.EDITORIAL)
				{
					departmentName = "EDITORIAL";
				}
				else if(this.department == DepartmentConstants.MARKETING)
				{
					departmentName = "MARKETING";
				}
				return departmentName;
			}
		}

		/// <summary>
		/// Added IDisplayable interface method
		/// </summary>
		/// <returns></returns>
		public string GetDisplayText()
		{
			string message;
			message = "Department: " + this.DepartmentName + "\n" +
					  "First Name: " + this.firstName + "\n" +
					  "Last Name: " + this.lastName + "\n" +
					  "Salary: " + this.salary + "\n";
			return message;
		}
	}
}
