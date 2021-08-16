using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewProblems.Answers
{
	public static class Problem6
	{
		/// <summary>
		/// Write a function that takes an array of numbers as a parameter.
		/// The function should return a collection of arrays representing two sides of the original array -
		/// split at the equilibrium point such that the sum of both arrays is equal.
		/// For the purposes of this exercise,
		/// you may assume that there will always be an equilibrium point in the provided array.
		/// </summary>
		/// <param name="arr">
		/// An array of numbers that contains an equilibrium point.
		/// You may assume that there will always be an equilibrium point in the provided array.
		/// </param>
		/// <returns>
		/// A collection of arrays representing two sides of the original array.
		/// Both sides can be summed to get the same number.
		/// </returns>
		/// <example>
		/// CreateEquilibriumArrays(new [] { 1, 2, 3 });  // [[1, 2], [3]]
		/// CreateEquilibriumArrays(new [] { 2, 3, 1, 5, 4, 7] });  // [[2, 3, 1, 5], [4, 7]]
		/// </example>
		public static (int[], int[]) CreateEquilibriumArrays(int[] arr)
		{
			//List<int> listArr = new List<int>();
			int n = arr.Length;
			//int eq;
			//int left, right;
			//for(int i = 0; i< p; i++)
			//{
			//	left = 0;
			//	right = 0;
			//	for(int j=0; j< i; j++)
			//	{
			//		left += arr[j];
			//	}
			//	for (int j =i+1; j < p; j++)
			//	{
			//		right += arr[j];
			//	}
			//	if(left == right)
			//	{
			//		eq= i;
			//	}
			//}
			var firstArray = new int[] { };
			var secondArray = new int[] { };

			int splitPoint = splitpoint(arr);
			if(splitPoint != -1|| splitPoint != n)
			{
				firstArray = arr.ToList().Take(n / 2).ToArray();
				secondArray = arr.Skip(n / 2).ToArray();
			}
			return new(firstArray, secondArray);

		}
private static int splitpoint(int[] arr)
		{
			//List<int> listArr = new List<int>();
			int n = arr.Length;
			//int eq;
			//int left, right;
			//for(int i = 0; i< p; i++)
			//{
			//	left = 0;
			//	right = 0;
			//	for(int j=0; j< i; j++)
			//	{
			//		left += arr[j];
			//	}
			//	for (int j =i+1; j < p; j++)
			//	{
			//		right += arr[j];
			//	}
			//	if(left == right)
			//	{
			//		eq= i;
			//	}
			//}
			int leftSum = 0;
			for (int i = 0; i < n; i++)
			{
				leftSum += arr[i];
				int rightSum = 0;

				for (int j = i + 1; j < n; j++)
				{
					rightSum += arr[j];
				}

				if (leftSum == rightSum)
				{
					return i + 1;
				}
			}
			return -1;
		}
	}
}
