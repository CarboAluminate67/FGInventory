public class Items
{
    private int _quantity;
    private string _name;

    public Items(int quant, string name)
    {
        _quantity = quant;
        _name = name;
    }

    public void AddItems(int quant)
    {
        _quantity += quant;
    }

    public void NewQuant(int quant)
    {
        _quantity = quant;
    }

    public int GetQuant()
    {
        return _quantity;
    }

    public int GetName()
    {
        return _name;
    }
}