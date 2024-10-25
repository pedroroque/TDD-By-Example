namespace Domain;

public class Dollar
{
    public int Ammount { get; init; }
    public Dollar(int ammount)
    {
       Ammount = ammount;
    }

    public Dollar Times(int multiplier) => new(Ammount * multiplier);
}
