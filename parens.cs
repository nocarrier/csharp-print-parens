/// <summary>
///  Recursive Paran Augmentator: By Shawn J. Molloy
/// </summary>

using System;

namespace Int32.Parse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PrintParens (3);
		}

		private static void printParen(int l,int r,char[] str, int count) {

			//Console.Write ("count:{0} ", count);

			if (l < 0 || r < 0)
				return;
			if (l == 0 && r == 0){
				Console.WriteLine (str);
			}
			else {
				if (l > 0) {
					//Console.Write ("r:{0} ", r);
					str [count] = '(';
					printParen (l - 1, r, str, count + 1);
				}
				if (r > 0) {
					//Console.Write ("l:{0} ", l);
					str [count] = ')';
					printParen (l, r - 1, str, count + 1);
				}
			}
		}

		public static void PrintParens(int count)
		{
			char[] str = new char[count * 2];
			printParen (count, count, str, 0);
		}
	}
}