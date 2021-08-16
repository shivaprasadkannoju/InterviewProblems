using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem2;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 2 - Factorial Tests")]
	public class Problem2Tests
	{
		[TestMethod("1")]
		public void One()
		{
			Assert.AreEqual(Factorial(1), 1);
		}

		[TestMethod("5")]
		public void Five()
		{
			Assert.AreEqual(Factorial(5), 120);
		}

		[TestMethod("8")]
		public void Eight()
		{
			Assert.AreEqual(Factorial(8), 40320);
		}
	}
}
