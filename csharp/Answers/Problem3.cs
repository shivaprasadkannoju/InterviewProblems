using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewProblems.Answers
{
	public static class Problem3
	{
		/// <summary>
		/// At each stop, passengers get on and off.
		/// Create a function that takes a collection of arrays representing stops.
		/// Each array will contain two integer values – the first representing passengers boarding at the stop
		/// and the second representing passengers alighting at the stop.
		/// This function should calculate the total passenger load at the bus’s last stop.
		/// </summary>
		/// <param name="busStops">
		/// A collection of arrays representing bus stops. Each Array contains two integer values.
		/// The first representing the total number of passengers boarding at that stop
		/// and the second representing the total number of passengers alighting at that stop.
		/// You may assume that this array will not be empty.
		/// </param>
		/// <returns>The total number of passengers at the bus’s last stop.</returns>
		/// <example>
		/// PassengerLoad(new int[][] { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }); // 5
		/// </example>
	
		public static int PassengerLoad(int[][] busStops)
		{
			// Your code goes below.
			int i, j, b = 0;
		
			List<int> board = new List<int>();
			
			int sum = 0;

			for (j = 0; j < 2; ++j)
			{
				for (i = 0; i <busStops.Length; ++i)
				{

					// Add the element
					sum = sum + busStops[i][j];
					
					
					

				}
				board.Add(sum);
				sum = 0;

			}
			int[] Unboard = board.ToArray();
			return b = Unboard[0] - Unboard[1];

		}

		
		
	}
}
