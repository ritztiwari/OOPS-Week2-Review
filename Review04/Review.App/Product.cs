
using System;
namespace Review.App
{   //sort using comparer
    public class Product
    { 
        public string ProductCode { get; set;} //properties
        public int Price{ get; set;}
        public int  Quantity{ get;set;}
        public Product( string productCode, int price, int quantity) //constructor
        {
            if(quantity < 0)
            {
                throw new Exception("Invalid quantity");
            }
            ProductCode = productCode;
            Price = price;
            Quantity = quantity;

        }

    }

  
}

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
