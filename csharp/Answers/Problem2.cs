using System;

namespace InterviewProblems.Answers
{
	public static class Problem2
	{
		/// <summary>
		/// Write a factorial function.
		/// The function should take a single positive integer and return a single integer value representing its factorial.
		/// </summary>
		/// <param name="value">
		/// The number to calculate the factorial of. You may assume that value is greater than or equal to 1.
		/// </param>
		/// <returns>
		/// The factorial of the given number.
		/// </returns>
		/// <example>
		/// Factorial(5) // 120
		/// </example>
		public static long Factorial(int value)
		{
			int num = 0;

			num = value;
			for (int i = num - 1; i > 0; i--)
			{
				num *= i;
			}
			return num;
		}
	}
}
