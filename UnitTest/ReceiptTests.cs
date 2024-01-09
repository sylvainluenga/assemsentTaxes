using NUnit.Framework;
using System;

[TestFixture]    // The [TestFixture] attribute indicates that this class contains NUnit tests.

public class ReceiptTests  //The ReceiptTests class is the test fixture containing individual test methods.
{
    [Test]
    // This test ensures that the AddItem method of the Receipt class correctly adds an item to the items collection.
    public void AddItem_AddsItemToReceipt() 
    {
        // Arrange
        Receipt receipt = new Receipt();
        Item item = new Item("Book", 12.99);

        // Act
        receipt.AddItem(item);

        // Assert
        Assert.AreEqual(1, receipt.items.Count);
        Assert.AreEqual(item, receipt.items[0]);
    }

    [Test]
    // This test verifies that the CalculateSalesTax method correctly calculates sales tax for different items.
    // The expected values are hardcoded based on the input items.
    public void CalculateSalesTax_ReturnsCorrectSalesTax() 
    {
        // Arrange
        Receipt receipt = new Receipt();
        Item item1 = new Item("Book", 12.99, isImported: false);
        Item item2 = new Item("music CD", 25.99, isImported: true);

        // Act
        double salesTax1 = receipt.CalculateSalesTax(item1);
        double salesTax2 = receipt.CalculateSalesTax(item2);

        // Assert
        Assert.AreEqual(0.0, salesTax1);
        Assert.AreEqual(3.9, Math.Round(salesTax2, 2));
    }

    [Test]
    //This test checks that the GenerateReceipt method produces the correct total cost and total sales tax for a receipt with two items.
    public void GenerateReceipt_PrintsCorrectOutput() 
    {
        // Arrange
        Receipt receipt = new Receipt();
        Item item1 = new Item("Book", 12.99, isImported: false);
        Item item2 = new Item("music CD", 25.99, isImported: true);

        receipt.AddItem(item1);
        receipt.AddItem(item2);

        // Act
        var result = receipt.GenerateReceipt();

        // Assert
        Assert.AreEqual(42.88, Math.Round(result.TotalCost, 2));
        Assert.AreEqual(3.9, Math.Round(result.TotalSalesTax, 2));
    }
}
