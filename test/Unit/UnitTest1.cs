using Lib1;
using NUnit.Framework;

namespace Unit;

public class Tests
{
    [TestCase("Hello"      ,  5, false)]
    [TestCase("Hello World", 11, false)]
    [TestCase(""           ,  0, true )]
    [TestCase(null         ,  0, true )]
    public void Test1(string? str, int expectedLength, bool expectedIsNullOrEmpty)
    {
        var actualLength        = str?.Length ?? 0;
        var actualIsNullOrEmpty = str.IsNullOrEmpty();

        Assert.That(actualLength       , Is.EqualTo(expectedLength)       );
        Assert.That(actualIsNullOrEmpty, Is.EqualTo(expectedIsNullOrEmpty));
    }
}
