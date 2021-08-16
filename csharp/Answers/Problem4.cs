using System;
using System.Linq;

namespace InterviewProblems.Answers
{
	public static class Problem4
	{
		/// <summary>
		/// Given a collection of integers, create a new collection containing the difference between each consecutive element in the collection.
		/// </summary>
		/// <param name="arr">
		/// A collection of integers.
		/// You will find the difference between each consecutive element in this collection.
		/// You may assume that this array is not empty and will contain at least two elements.
		/// </param>
		/// <returns>A new collection of integers that represents the difference between each consecutive element in the input collection.</returns>
		/// <example>
		///	ConsecutiveDistance(new[] { 4, 3, 6, 8, 2 }); // [ 1 , -3, -2, 6 ];
		/// </example>
		public static int[] ConsecutiveDistance(int[] arr)
		{
			var d = arr.ToList().Take(arr.Length - 1).Select((v, i) => arr[i + 1] - v);
			return d.Select(c=> -c).ToArray();
		}
	}
}
