using NUnit.Framework;
using Vowel_Count;
namespace Vowel_Count_UniTest;

public class Tests
{
    
    [TestCase("a e i o u")]
    public void Test1(string data)
    {
        Assert.AreEqual(5, VowelCount.VowelCounter(data));
    }
}