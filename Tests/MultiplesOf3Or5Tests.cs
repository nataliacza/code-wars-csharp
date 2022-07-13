using MultiplesOf3Or5Challenge;
using NUnit.Framework;

namespace MultiplesOf3Or5Tests;


[TestFixture]
public class Tests
{
    [Test]
    public void TestList_10_Returns_23()
    {
        Assert.AreEqual(23, MultiplesOf3Or5.SolutionList(10));
        // 3, 5, 6 and 9
    }

    [Test]
    public void TestList_16_Returns_60()
    {
        Assert.AreEqual(60, MultiplesOf3Or5.SolutionList(16));
        // 3, 5, 6, 9, 10, 12, 15, [15]
    }




    [Test]
    public void TestSum_10_Returns_23()
    {
        Assert.AreEqual(23, MultiplesOf3Or5.SolutionSum(10));
        // 3, 5, 6 and 9
    }

    [Test]
    public void TestSum_16_Returns_60()
    {
        Assert.AreEqual(60, MultiplesOf3Or5.SolutionSum(16));
        // 3, 5, 6, 9, 10, 12, 15, [15]
    }



    [Test]
    public void TestLinq_10_Returns_23()
    {
        Assert.AreEqual(23, MultiplesOf3Or5.SolutionLinq(10));
        // 3, 5, 6 and 9
    }


}
