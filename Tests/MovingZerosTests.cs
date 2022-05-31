using NUnit.Framework;
using System;
using MovingZerosToTheEnd;

namespace ZerosTests;

[TestFixture]
public class MovingZerosTests
{
    [Test]
    public void MoveZeroes1()
    {
        Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, 
            Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
    }

    [Test]
    public void MoveZeroes2()
    {
        Assert.AreEqual(new int[] { 5, 1, 2, 0, 0 },
            Kata.MoveZeroes(new int[] { 0, 5, 0, 1, 2 }));
    }

    [Test]
    public void MoveZeroes3()
    {
        Assert.AreEqual(new int[] { 2, 5, 0 },
            Kata.MoveZeroes(new int[] { 0, 2, 5 }));
    }

    [Test]
    public void MoveZeroes4()
    {
        Assert.AreEqual(new int[] { },
            Kata.MoveZeroes(new int[] { }));
    }


    [Test]
    public void MoveZeroesIndex1()
    {
        Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 },
            Kata.MoveZeroesIndex(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
    }

    [Test]
    public void MoveZeroesIndex2()
    {
        Assert.AreEqual(new int[] { 5, 1, 2, 0, 0 },
            Kata.MoveZeroesIndex(new int[] { 0, 5, 0, 1, 2 }));
    }

    [Test]
    public void MoveZeroesIndex3()
    {
        Assert.AreEqual(new int[] { 2, 5, 0 },
            Kata.MoveZeroesIndex(new int[] { 0, 2, 5 }));
    }

    [Test]
    public void MoveZeroesIndex4()
    {
        Assert.AreEqual(new int[] { },
            Kata.MoveZeroesIndex(new int[] { }));
    }
}
