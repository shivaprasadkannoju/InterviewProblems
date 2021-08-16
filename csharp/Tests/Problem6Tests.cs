using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem6;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 6 - Create Equilibrium Arrays Tests")]
	public class Problem6Tests
	{
		[TestMethod("[1, 2, 3]")]
		public void EQ1()
		{
			var (left, right) = CreateEquilibriumArrays(new[] { 1, 2, 3 });
			CollectionAssert.AreEquivalent(left, new[] { 1, 2 });
			CollectionAssert.AreEquivalent(right, new[] { 3 });
		}

		[TestMethod("[2, 3, 1, 5, 4, 7]")]
		public void EQ2()
		{
			var (left, right) = CreateEquilibriumArrays(new[] { 2, 3, 1, 5, 4, 7 });
			CollectionAssert.AreEquivalent(left, new[] { 2, 3, 1, 5 });
			CollectionAssert.AreEquivalent(right, new[] { 4, 7 });
		}

		[TestMethod("[1, 1, 1, 1, 1, 1]")]
		public void EQ3()
		{
			var (left, right) = CreateEquilibriumArrays(new[] { 1, 1, 1, 1, 1, 1 });
			CollectionAssert.AreEquivalent(left, new[] { 1, 1, 1 });
			CollectionAssert.AreEquivalent(right, new[] { 1, 1, 1 });
		}
	}
}
