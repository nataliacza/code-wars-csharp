using NUnit.Framework;
using System;
using UniqueInOrderChallenge;

namespace UniqueOrderTests;

public class UniqueInOrderTests
{
    [Test]
    public void EmptyTestA()
    {
        Assert.AreEqual("", UniqueOrder.UniqueInOrder(""));
    }

    [Test]
    public void TestA()
    {
        Assert.AreEqual("ABCDAB", UniqueOrder.UniqueInOrder("AAAABBBCCDAABBB"));
    }

    [Test]
    public void TestAA()
    {
        Assert.AreEqual("ABCcAD", UniqueOrder.UniqueInOrder("ABBCcAD"));
    }





    [Test]
    public void EmptyTestB()
    {
        Assert.AreEqual("", UniqueOrder.UniqueInOrder2(""));
    }

    [Test]
    public void TestB()
    {
        Assert.AreEqual("ABCDAB", UniqueOrder.UniqueInOrder2("AAAABBBCCDAABBB"));
    }

    [Test]
    public void TestBB()
    {
        Assert.AreEqual("ABCcAD", UniqueOrder.UniqueInOrder2("ABBCcAD"));
    }

}
