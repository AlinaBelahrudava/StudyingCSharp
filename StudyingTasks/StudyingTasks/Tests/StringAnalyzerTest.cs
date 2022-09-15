using NUnit.Framework;
using StudyingTasks.StringAnalysys;

namespace StudyingTasks.Tests
{
    [TestFixture]
    internal class StringAnalyzerTest
    {

        [TestCase("assss  sdfgh  jklzxcvbnmmmhdf 123456", " jklzxcvbnm")]
        [TestCase("assss  sdfgh 1234 jklzxcvbnmmm1 0123456789", "1234 jklzxcvbnm")]
        [TestCase("assss  sdfgh 1234  jklzxcvbmmmhdf  0123456789", " 0123456789")]
        public void verifyUniqueSequence(string inputString, string expectedresult)
        {
            StringAnalyzer stringAnalyzer = new();
            Assert.AreEqual(expectedresult, stringAnalyzer.GetMaxUniqueSequence(inputString));
        }

        [TestCase("abcdefg", "a")]
        [TestCase("1234556", null)]
        [TestCase("aabbbc", "bbb")]
        [TestCase("1111aaa", "aaa")]
        [TestCase("1111     aaa", "aaa")]
        public void verifySameLettersSequence(string inputString, string expectedresult)
        {
            StringAnalyzer stringAnalyzer = new();
            Assert.AreEqual(expectedresult, stringAnalyzer.GetMaxSameLettersSequence(inputString));
        }

        [TestCase("123456", "1")]
        [TestCase("asdfghjjjj", null)]
        [TestCase("111aaaa344445", "4444")]
        [TestCase("1111     aaa", "1111")]
        public void verifySameDigitsSequence(string inputString, string expectedresult)
        {
            StringAnalyzer stringAnalyzer = new();
            Assert.AreEqual(expectedresult, stringAnalyzer.GetMaxSameDigitsSequence(inputString));
        }
    }
}
