using Domain;

namespace Tests;

public class MoneyTests
{
    [Fact]
    public void Multiplication()
    {
        var five = new Dollar(5);

        five.Times(2);
        
        Assert.Equal(10, five.Ammount);
    }
}