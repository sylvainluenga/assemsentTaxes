# SALES TAXES Problem

## Description

This project is runned with IDE: Microsoft Visual studio and not Visual studio code
This project is a taxes sales project developed in C# to i made it in two part the:
The solution [ which run the test and logic given in the problem ]
Unit testing libraries of my choice [by using NUnit].

## How to run the project

Open the project with Visual studio then click run if you on the fisrt part of the project [ SALESTAXESProblem]
to run the second part of logic [Nunit]:
click : UnitTest-> go to ReceiptTest.cs file and run

### NB

to get the output request on the problem
you need to understand this 4 logics:
Imported and Tax Exempt: None of the provided items.
Imported and Not Tax Exempt: None of the provided items.
Not Imported and Tax Exempt: Book and Chocolate bar.
Not Imported and Not Tax Exempt: Music CD.

#### Explanation of the first part of the project [SALETAXESProblem]

Item Class:

The Item class represents an item that can be purchased.
It has properties like Name, Price, IsExempt (indicating if the item is exempt from basic sales tax),
and IsImported (indicating if the item is imported and subject to additional import duty).

Receipt Class:

The Receipt class represents a shopping receipt.
It has a private list items to store the items in the receipt.
The AddItem method is used to add items to the receipt.
The quantity parameter allows adding multiple units of the same item.
The CalculateSalesTax method calculates the sales tax for a given item based on the rules provided in the problem statement.
It considers basic sales tax, exemption status, and import duty.
The IsExempt method checks if an item is exempt based on its name.
The GenerateReceipt method prints the details of the items in the receipt, including their prices after tax, the total sales taxes, and the overall total cost.

Example Usage (Main Method):

In the Main method, an instance of the Receipt class is created.
Three items are added to the receipt using the AddItem method, each represented by an instance of the Item class.
The GenerateReceipt method is then called to print out the receipt details.

Rounding:

Similar to the Python version, rounding of the sales tax is done using the formula (np/100 rounded up to the nearest 0.05).
This is achieved using the Math.Ceiling function and multiplying by 0.05.
