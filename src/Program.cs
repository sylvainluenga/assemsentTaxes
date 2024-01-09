class Program
{
    static void Main()
    {
        Receipt receipt = new();

        // User input for items
        while (true)
        {
            Console.Write("Enter item name (or 'done' to finish): ");
            string itemName = Console.ReadLine();

            if (itemName.ToLower() == "done")
                break;

            Console.Write("Enter item price: ");
            double itemPrice;
            while (!double.TryParse(Console.ReadLine(), out itemPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
            }

            Console.Write("Is the item exempt from basic sales tax? (true/false): ");
            bool isExempt = bool.Parse(Console.ReadLine());

            Console.Write("Is the item imported? (true/false): ");
            bool isImported = bool.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid quantity.");
            }

            Item newItem = new Item(itemName, itemPrice, isExempt, isImported);
            receipt.AddItem(newItem, quantity);
        }

        // Generate and display the receipt
        // NB before i run this code i had to know which items is according to the question:
        // Imported and Tax Exempt: None of the provided items.
        // Imported and Not Tax Exempt: None of the provided items.
        // Not Imported and Tax Exempt: Book and Chocolate bar
        // Not Imported and Not Tax Exempt: Music CD.
        receipt.GenerateReceipt();
    }
}