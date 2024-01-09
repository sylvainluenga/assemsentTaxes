public class Item
{
    public string Name { get; }
    public double Price { get; }
    public bool IsExempt { get; }
    public bool IsImported { get; }

    public Item(string name, double price, bool isExempt = false, bool isImported = false)
    {
        Name = name;
        Price = price;
        IsExempt = isExempt;
        IsImported = isImported;
    }
}