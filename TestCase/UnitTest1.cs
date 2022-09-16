namespace TestCase;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int number = 2;
        Assert.Equal(number, 2);
    }
}