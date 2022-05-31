using CheckPrimeNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PrimeNr;
public class PrimeNumberTests
{
    [TestFixture]
    public class SolutionTest
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(-1).Returns(false);
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
                yield return new TestCaseData(3).Returns(true);
                yield return new TestCaseData(4).Returns(false);
                yield return new TestCaseData(5).Returns(true);
                yield return new TestCaseData(6).Returns(false);
                yield return new TestCaseData(7).Returns(true);
                yield return new TestCaseData(8).Returns(false);
                yield return new TestCaseData(9).Returns(false);
                yield return new TestCaseData(10).Returns(false);
                yield return new TestCaseData(11).Returns(true);
                yield return new TestCaseData(13).Returns(true);
                yield return new TestCaseData(73).Returns(true);
                yield return new TestCaseData(75).Returns(false);
                yield return new TestCaseData(40).Returns(false);
                yield return new TestCaseData(5099).Returns(true);
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public bool SampleTest(int n) => PrimeNumber.IsPrime(n);
    }
}
