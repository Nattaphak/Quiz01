namespace TestCase;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string text = InEx.Revenue();
        Assert.Equal(text, "Total revenue : 236,154 Baht");
    }

    public void Test2()
    {
        string t = InEx.Expenses();
        Assert.Equal(t, "Total expenses : 213,069.55 Baht");
    }
}