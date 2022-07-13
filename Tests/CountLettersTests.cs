using CountLettersChallenge;
using NUnit.Framework;


namespace CountingTests;

[TestFixture]
public class CountLettersTests
{
    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", CountLetters.GetStrings("Chicago"));
        Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", CountLetters.GetStrings("Bangkok"));
        Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", CountLetters.GetStrings("Las Vegas"));
    }
}
