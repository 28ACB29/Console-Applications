namespace FutureValue
{
	public class FinancialCalculations
	{

		/// <summary>
		/// Copied functions from Main
		/// </summary>
		/// <param name="monthlyInvestment"></param>
		/// <param name="monthlyInterestRate"></param>
		/// <param name="months"></param>
		/// <returns></returns>
		public static double CalculateFutureValue(double monthlyInvestment, double monthlyInterestRate, int months)
		{
			double futureValue;
			futureValue = 0.0;
			for(int i = 1; i <= months; i++)
			{
				futureValue =
					(futureValue + monthlyInvestment) *
					(1 + monthlyInterestRate);
			}
			return futureValue;
		}
	}
}
