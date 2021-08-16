using System;

namespace InterviewProblems.Answers
{
	public static class Problem5
	{
		/// <summary>
		/// Write a function that takes a number as a parameter.
		/// The function should sum each digit of the number and determine if the resulting sum is a palindrome.
		/// NOTE: A palindrome is a word or number that stays the same when reversed (e.g. 121 or 5225)
		/// </summary>
		/// <param name="num">The number to check. You may assume a positive number.</param>
		/// <returns>True if the number is a palindrome, false otherwise.</returns>
		/// <example>fd
		/// IsDigitSumPalindrome(56);  // true  (digit sum is 11)
		/// IsDigitSumPalindrome(296); // false (digit sum is 17)
		/// </example>
		public static bool IsDigitSumPalindrome(int num)
		{
			var sum = 0;
			string result=string.Empty;
			while(num != 0)
			{
				sum += num % 10;
				num /= 10;
			}

			var sumString = sum.ToString();

			if(sumString != null)
			{
				for (int i = sumString.Length - 1; i >= 0; i--)
				{
					result += sumString[i].ToString();
				}
				if(result == sumString)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			return false;
		}
	}
}
