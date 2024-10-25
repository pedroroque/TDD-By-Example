using Domain;

namespace Tests;

public class MoneyTests
{
    [Fact]
    public void Multiplication()
    {
        var five = new Dollar(5);

        Assert.Equal(10, five.Times(2).Ammount);
    }

    [Fact]
    public void ShouldBeAbleToMultiplyTwoTimes() {
        var five = new Dollar(5);

        Assert.Equal(10, five.Times(2).Ammount);
        Assert.Equal(15, five.Times(3).Ammount);
    }
}