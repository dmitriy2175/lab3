using NUnit.Framework;

namespace lab22;

public class Tests
{

    [Test]
    public void TestSum()
    {
        Assert.AreEqual(new RomanNumber(15), new RomanNumber(10) + new RomanNumber(5));
    }
    [Test]
    public void TestSub()
    {
        Assert.AreEqual(new RomanNumber(5), new RomanNumber(10) - new RomanNumber(5));
    }
    [Test]
    public void TestDiv()
    {
        Assert.AreEqual(new RomanNumber(2), new RomanNumber(10) / new RomanNumber(5));
    }
    [Test]
    public void TestMul()
    {
        Assert.AreEqual(new RomanNumber(50), new RomanNumber(10) * new RomanNumber(5));
    }
    [Test]
    public void TestToStringl()
    {
        Assert.AreEqual("X",new RomanNumber(10).ToString());
    }
    [Test]
    public void TestClon()
    {
        RomanNumber a = new RomanNumber(10);
        Assert.AreEqual(a, a.Clone());
    }
    [Test]
    public void TestCompareTo()
    {
        Assert.AreEqual(0, new RomanNumber(9).CompareTo(new RomanNumber(9)));
        Assert.AreEqual(-1, new RomanNumber(7).CompareTo(new RomanNumber(9)));
        Assert.AreEqual(1, new RomanNumber(9).CompareTo(new RomanNumber(7)));
    }
    [Test]
    public void TestEqualso()
    {
        Assert.AreEqual(true, new RomanNumber(9).Equals(new RomanNumber(9)));
        Assert.AreEqual(false, new RomanNumber(9).Equals(new RomanNumber(8)));
    }
}



