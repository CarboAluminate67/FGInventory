public class Perish : Item
{
    private int _expTime;

    public Perish(string name, int quant, int exp) : base(name, quant)
    {
        _expTime = exp;
    }


}