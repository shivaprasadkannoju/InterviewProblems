using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem3;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 3 - Passenger Load Tests")]
	public class Problem3Tests
	{
		[TestMethod("[[5, 3]]")]
		public void Single()
		{
			var load = PassengerLoad(new int[][] { new[] { 5, 3 } });
			Assert.AreEqual(load, 2);
		}

		[TestMethod("[[8, 4], [19, 4], [6, 3], [0, 12], [7, 8], [4, 4]]")]
		public void Multiple()
		{
			var load = PassengerLoad(new int[][]
			{
				new[] { 8, 4 },
				new[] { 19, 4 },
				new[] { 6, 3 },
				new[] { 0, 12 },
				new[] { 7, 8 },
				new[] { 4, 4 }
			});
			Assert.AreEqual(load, 9);
		}
	}
}
