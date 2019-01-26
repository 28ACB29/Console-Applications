using System;
using System.Collections.Generic;

namespace Data
{
	public class GenericStack<T>
	{
		private Stack<T> stack = new Stack<T>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="element"></param>
		public void Push(T element)
		{
			Console.Out.WriteLine("Push: " + element);
			this.stack.Push(element);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public T Pop()
		{
			Console.Out.WriteLine("Pop: " + this.stack.Peek());
			return this.stack.Pop();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public T Peek()
		{
			Console.Out.WriteLine("Peek: " + this.stack.Peek());
			return this.stack.Peek();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public int Size()
		{
			return this.stack.Count;
		}
	}
}
