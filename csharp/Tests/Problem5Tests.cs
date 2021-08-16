using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem5;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 5 - Digit Sum Palindrome Tests")]
	public class Problem5Tests
	{
		[TestMethod("56")]
		public void FiftySix()
		{
			Assert.IsTrue(IsDigitSumPalindrome(56));
		}

		[TestMethod("958")]
		public void NineHundredFiftyEight()
		{
			Assert.IsTrue(IsDigitSumPalindrome(958));
		}

		[TestMethod("296")]
		public void TwoHundredNintySix()
		{
			Assert.IsFalse(IsDigitSumPalindrome(296));
		}
	}
}
