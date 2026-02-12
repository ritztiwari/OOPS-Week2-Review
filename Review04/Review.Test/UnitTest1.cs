namespace Review.Test;
/*
Product Inventory Management
Scenario:

Warehouse system manages product inventory.
Requirements:

Use Dictionary<string, Product>

Product has ProductCode, Price, Quantity

Sort products by price descending

Prevent duplicate product codes

Throw exception if quantity < 0

Edge Cases:

Zero quantity products

Price tie

Invalid product code format

NUnit:

Test sorting by price

Validate duplicate key handling
*/
using NUnit.Framework;
using Review.App;

[TestFixture]
public class Tests
{
     Management management; //class type
     Product product ;//class type
    [SetUp]
    public void Setup()
    {
     management  = new Management(); //run for every test cases
    }

    [Test]
    public void TestSortingByPPrice() //test case
    {

            management.AddProduct(new Product("AB12", 10, 5));
            management.AddProduct(new Product("AB13", 15, 3));
            management.AddProduct(new Product("AB14", 7, 8));
     
            var sortedProducts = management.SortedByPriceDesc();
     
            Assert.That(sortedProducts[0].ProductCode, Is.EqualTo("AB13"));
            Assert.That(sortedProducts[1].ProductCode, Is.EqualTo("AB12"));
            Assert.That(sortedProducts[2].ProductCode, Is.EqualTo("AB14"));
        
    }
    [Test]
    public void TestDuplicate() //test case
     {
         
          Assert.Throws<System.Exception>(() => management.AddProduct(new Product("AB15", 1, 6)));

          
     }
}

