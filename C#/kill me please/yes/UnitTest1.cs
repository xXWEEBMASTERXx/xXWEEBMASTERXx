namespace yes;
using answer;

public class Tests
{
    [Test]
    public void ResetTest()
    {
        CashRegister SelfCheckout = new CashRegister();
        Assert.IsTrue(SelfCheckout.StartNewShopping());
    }
    [Test]
    public void ScanTest()
    {
        Assert.IsTrue();
    }
}