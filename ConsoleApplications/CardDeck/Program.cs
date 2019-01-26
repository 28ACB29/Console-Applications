using System;

namespace CardDeck
{
	public class Program
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cards"></param>
		/// <returns></returns>
		public static int[] LoadCards(int[] cards)
		{
			for(int n = 0; n < 52; n++)
			{
				cards[n] = (n % 13) + 1;
			}
			return cards;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cards"></param>
		/// <param name="suits"></param>
		/// <returns></returns>
		public static string PrintCards(int[] cards, string[] suits)
		{
			string message;
			message = "";
			for(int n = 0; n < 52; n++)
			{
				if((n % 13) == 0)
				{

					//The division operator returns the quotient
					message += "\n" + suits[n / 13] + " " + cards[n] + " ";
				}
				else
				{
					message += cards[n] + " ";
				}
			}
			message += "\n";
			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cards"></param>
		/// <returns></returns>
		public static int[] ShuffleCards(int[] cards)
		{
			Random random;
			int randomCard;
			int temp;
			random = new Random();
			randomCard = 0;
			temp = 0;
			for(int n = 0; n < 100; n++)
			{
				randomCard = (int) ((random.NextDouble() * 50) + 1);
				for(int p = 0; p < 52; p++)
				{
					if(p + randomCard < 52)
					{

						//Switch cards
						temp = cards[p + randomCard];
						cards[p + randomCard] = cards[p];
						cards[p] = temp;
					}
				}
			}
			return cards;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hands"></param>
		/// <param name="cards"></param>
		/// <returns></returns>
		public static int[,] LoadHands(int[,] hands, int[] cards)
		{
			for(int n = 0; n < 20; n++)
			{
				hands[n / 5, n % 4] = cards[n];
			}
			return hands;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hands"></param>
		/// <param name="suits"></param>
		/// <returns></returns>
		public static string PrintHands(int[,] hands, string[] suits)
		{
			string message;
			message = "";
			for(int n = 0; n < 20; n++)
			{
				if((n % 5) == 0)
				{
					message += "\n" + suits[n / 5] + hands[n / 5, n % 4] + " ";
				}
				else
				{
					message += suits[n / 5] + hands[n / 5, n % 4] + " ";
				}
			}
			message += "\n";
			return message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			int[] cards;
			string message;
			int[,] hands;

			//Added new array for the names of the suits and cards
			string[] suits = { "C", "D", "H", "S" };
			cards = new int[52];

			//Added code to load the cards, print the cards and shuffle the cards
			cards = LoadCards(cards);
			message = PrintCards(cards, suits);
			Console.Out.WriteLine(message);
			cards = ShuffleCards(cards);
			hands = new int[5, 4];
			hands = LoadHands(hands, cards);
			message = PrintHands(hands, suits);
			Console.Out.WriteLine(message);

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
