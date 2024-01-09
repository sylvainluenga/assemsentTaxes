using SALESTAXESProblem;

public class Receipt   // This code defines a class named Receipt
{
    public List<Item> items; // The class has a private field named items, which is a list of objects of type Item. This list will store the items on the receipt.

    public Receipt()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item, int quantity = 1)
    {
        items.AddRange(Enumerable.Repeat(item, quantity));
    }

    public double CalculateSalesTax(Item item)
    {
        const double basicTaxRate = 0.1;

        double taxRate = IsExempt(item) ? 0 : basicTaxRate;

        if (item.IsImported)
        {
            taxRate += 0.05;
        }

        double tax = item.Price * taxRate;
        double roundedTax = Math.Ceiling(tax / 0.05) * 0.05;
        return roundedTax;
    }

    private bool IsExempt(Item item)
    {
        // Check if the item is exempt (books, music CD, chocolate bar)
        string[] exemptCategories = { "book", "music CD", "chocolate bar" };
        return exemptCategories.Any(category => item.Name.ToLower().Contains(category));
    }

    public ReceiptResult GenerateReceipt()
    {
        double totalSalesTax = 0;
        double totalCost = 0;

        foreach (var item in items)
        {
            double salesTax = CalculateSalesTax(item);
            totalSalesTax += salesTax;
            totalCost += item.Price + salesTax;
            Console.WriteLine($"{item.Name}: {item.Price + salesTax:F2}");
        }

        Console.WriteLine($"Sales Taxes: {totalSalesTax:F2}");
        Console.WriteLine($"Total: {totalCost:F2}");

        return new ReceiptResult
        {
            TotalSalesTax = totalSalesTax,
            TotalCost = totalCost
        };
    }
}