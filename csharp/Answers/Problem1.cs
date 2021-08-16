using System;
using System.Linq;

namespace InterviewProblems.Answers
{
	public static class Problem1
	{
		/// <summary>
		/// Write a function that returns the length of the longest string in an array.
		/// It should accept an array of string values as a parameter and return a single
		/// integer representing the longest string.
		/// </summary>
		/// <param name="values">
		/// Array of string values to find the longest string in. You may assume that the array will not be null or empty.
		/// </param>
		/// <returns>The length of the longest string in the array.</returns>
		/// <example>
		/// LongestStr(new[] { "the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" }); // 6
		/// </example>
		public static int LongestStr(string[] values)
		{
			return values.ToList().OrderByDescending(str => str.Length).FirstOrDefault().Length;
		}
	}
}
