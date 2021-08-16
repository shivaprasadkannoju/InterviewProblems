using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem4;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 4 - Consecutive Distance Tests")]
	public class Problem4Tests
	{
		[TestMethod("[4, 3, 6, 8, 2]")]
		public void D1()
		{
			var result = ConsecutiveDistance(new[] { 4, 3, 6, 8, 2 });
			CollectionAssert.AreEquivalent(result, new[] { 1, -3, -2, 6 });
		}

		[TestMethod("[0, 0, 1, 1, 5, 10, 100, 1000, 100, 999]")]
		public void D2()
		{
			var result = ConsecutiveDistance(new[] { 0, 0, 1, 1, 5, 10, 100, 1000, 100, 999 });
			CollectionAssert.AreEquivalent(result, new[] { 0, -1, 0, -4, -5, -90, -900, 900, -899 });
		}
	}
}
