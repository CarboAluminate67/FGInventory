public abstract class Item
{
    private int _quantity;
    private string _name;

    public Item(string name, int quant)
    {
        _quantity = quant;
        _name = name;
    }

    public virtual void AddItems(int quant)
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