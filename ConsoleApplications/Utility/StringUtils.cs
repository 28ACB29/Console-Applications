using System.IO;
using System.Text;

namespace Utility
{
	public class StringUtils
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static string PadWithSpaces(string s, int length)
		{
			StringBuilder sb;
			if(s.Length < length)
			{
				sb = new StringBuilder(s);
				while(sb.Length < length)
				{
					sb.Append(" ");
				}
				return sb.ToString();
			}
			else
			{
				return s.Substring(0, length);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="output"></param>
		/// <param name="length"></param>
		/// <param name="s"></param>
		public static void writeFixedString(BinaryWriter output, int length, string s)
		{
			for(int i = 0; i < length; i++)
			{
				if(i < s.Length)
				{

					// write char
					output.Write(s[i]);
				}
				else
				{

					// write unicode zero
					output.Write('0');
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static string GetFixedString(BinaryReader input, int length)
		{
			StringBuilder sb;
			char c;
			sb = new StringBuilder();
			for(int i = 0; i < length; i++)
			{
				c = input.ReadChar();

				// if char is not Unicode zero
				// Add to string
				if(c != 0)
				{
					sb.Append(c);
				}
			}
			return sb.ToString();
		}
	}
}
