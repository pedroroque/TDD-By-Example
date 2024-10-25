namespace Domain;

public class Dollar
{
    public int Ammount { get; private set; }
    public Dollar(int ammount)
    {
       Ammount = ammount;
    }

    public void Times(int multiplier)
    {
        Ammount *= multiplier;
    }
}
