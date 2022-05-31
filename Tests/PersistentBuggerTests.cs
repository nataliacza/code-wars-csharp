using System;
using NUnit.Framework;
using PersistentBuggerChallenge;


namespace PersistentB;

[TestFixture]
public class PersistTests
{
    [Test]
    public void Test39()
    {
        Assert.AreEqual(3, Persist.Persistence(39));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(0, Persist.Persistence(4));
    }

    [Test]
    public void Test25()
    {
        Assert.AreEqual(2, Persist.Persistence(25));
    }

    [Test]
    public void Test999()
    {
        Assert.AreEqual(4, Persist.Persistence(999));
    }
}
