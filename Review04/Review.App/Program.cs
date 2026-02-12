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
using System;
using System.Text.RegularExpressions;

namespace Review.App
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Management management = new Management();
            Console.WriteLine("How many products to add : "); //
            int count = int.Parse(Console.ReadLine()); // no. of entries

            Regex regex= new Regex(@"^[A-Z]{2}\d{2}$"); //for validating the write format of code

            while(count-->0){// for getting n inputs   
              
            Console.WriteLine("Enter product code");
            string productCode = Console.ReadLine();
            if (!regex.IsMatch(productCode))
            {
                Console.WriteLine("invalid product code format");
                break;
            }
            Console.WriteLine("Enter price");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity");
            int quantity = int.Parse(Console.ReadLine());

                try
                {
                    Product product =new Product(productCode, price, quantity);
                    management.AddProduct(product);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine("product sroted in descending order of price");
            //sort by using IComparer
            foreach(var product in management.SortedByPriceDesc())
            {
                Console.WriteLine($"Product Code: {product.ProductCode}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            
           Console.WriteLine("Search product : "); //searching product by code
           var temp= management.GetProd("AB12");
           Console.WriteLine($"Product Code: {temp.ProductCode}, Price: {temp.Price}, Quantity: {temp.Quantity}");

        }
    }
}