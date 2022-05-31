using IPValidation;
using NUnit.Framework;

/*
TRUE
0.0.0.0
12.255.56.1
137.255.156.100

FALSE
abc.def.ghi.jkl
123.456.789.0
12.34.56
12.34.56.00
12.34.56.7.8
12.34.256.78
1234.34.56
pr12.34.56.78
12.34.56.78sf
12.34.56 .1
12.34.56.-1
123.045.067.089
*/


namespace IpTests;
public class IPValidationTests
{
    //[Test]
    //public void ValidateIpTests_UsingRegex_ShouldReturnTrue()
    //{
    //    Assert.AreEqual(true, Kata.is_valid_IP_regex("0.0.0.0"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_regex("12.255.56.1"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_regex("137.255.156.100"));
    //}

    //[Test]
    //public void ValidateIpTests_UsingRegex_ShouldReturnFalse()
    //{
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex(""));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("abc.def.ghi.jkl"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("123.456.789.0"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56.00"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56.7.8"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.256.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("1234.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("pr12.34.56.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56.78sf"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56 .1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("12.34.56.-1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_regex("123.045.067.089"));
    //}

    //[Test]
    //public void ValidateIpTests_UsingSystemIP_ShouldReturnTrue()
    //{
    //    Assert.AreEqual(true, Kata.is_valid_IP_system("0.0.0.0"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_system("12.255.56.1"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_system("137.255.156.100"));
    //}

    //[Test]
    //public void ValidateIpTests_UsingSystemIP_ShouldReturnFalse()
    //{
    //    Assert.AreEqual(false, Kata.is_valid_IP_system(""));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("abc.def.ghi.jkl"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("123.456.789.0"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56.00"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56.7.8"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.256.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("1234.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("pr12.34.56.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56.78sf"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56 .1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("12.34.56.-1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_system("123.045.067.089"));
    //}




    //[Test]
    //public void ValidateIpTests_MineAll_ShouldReturnTrue()
    //{
    //    Assert.AreEqual(true, Kata.is_valid_IP_mine("0.0.0.0"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_mine("12.255.56.1"));
    //    Assert.AreEqual(true, Kata.is_valid_IP_mine("137.255.156.100"));
    //}

    [Test]
    public void ValidateIpTests_Mine_1_ShouldReturnTrue()
    {
        Assert.AreEqual(true, Kata.is_valid_IP_mine("0.0.0.0"));
    }

    [Test]
    public void ValidateIpTests_Mine_2_ShouldReturnTrue()
    {
        Assert.AreEqual(true, Kata.is_valid_IP_mine("12.255.56.1"));
    }

    [Test]
    public void ValidateIpTests_Mine_3_ShouldReturnTrue()
    {
        Assert.AreEqual(true, Kata.is_valid_IP_mine("137.255.156.100"));
    }





    //[Test]
    //public void ValidateIpTests_MineAll_ShouldReturnFalse()
    //{
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine(""));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("abc.def.ghi.jkl"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("123.456.789.0"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.00"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.7.8"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.256.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("1234.34.56"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("pr12.34.56.78"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.78sf"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56 .1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.-1"));
    //    Assert.AreEqual(false, Kata.is_valid_IP_mine("123.045.067.089"));
    //}

    [Test]
    public void ValidateIpTests_Mine_1_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine(""));
    }

    [Test]
    public void ValidateIpTests_Mine_2_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("abc.def.ghi.jkl"));
    }

    [Test]
    public void ValidateIpTests_Mine_3_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("123.456.789.0"));
    }

    [Test]
    public void ValidateIpTests_Mine_4_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56"));
    }

    [Test]
    public void ValidateIpTests_Mine_5_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.00"));
    }

    [Test]
    public void ValidateIpTests_Mine_6_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.7.8"));
    }

    [Test]
    public void ValidateIpTests_Mine_7_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.256.78"));
    }

    [Test]
    public void ValidateIpTests_Mine_8_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("1234.34.56"));
    }

    [Test]
    public void ValidateIpTests_Mine_9_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("pr12.34.56.78"));
    }

    [Test]
    public void ValidateIpTests_Mine_10_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.78sf"));
    }

    [Test]
    public void ValidateIpTests_Mine_11_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56 .1"));
    }

    [Test]
    public void ValidateIpTests_Mine_12_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12.34.56.-1"));
    }

    [Test]
    public void ValidateIpTests_Mine_13_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("123.045.067.089"));
    }

    [Test]
    public void ValidateIpTests_Mine_14_ShouldReturnFalse()
    {
        Assert.AreEqual(false, Kata.is_valid_IP_mine("12\n.045.067.89"));
    }
}
