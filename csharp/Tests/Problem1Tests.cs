using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InterviewProblems.Answers.Problem1;

namespace InterviewProblems.Tests
{
	[TestClass]
	[TestCategory("Problem 1 - Max Length String Tests")]
	public class Problem1Tests
	{
		[TestMethod("Quick brown fox")]
		public void Fox()
		{
			var result = LongestStr(new[] { "the", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" });
			Assert.AreEqual(result, 6);
		}

		[TestMethod("Long")]
		public void Long()
		{
			var result = LongestStr(new[] { "long string 123", "short str", "tiny" });
			Assert.AreEqual(result, 15);
		}

		[TestMethod("Duplicates")]
		public void Duplicates()
		{
			var result = LongestStr(new[] { "test", "test", "hi" });
			Assert.AreEqual(result, 4);
		}
	}
}
