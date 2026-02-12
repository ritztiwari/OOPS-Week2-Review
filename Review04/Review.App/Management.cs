using System;
using System.Collections.Generic;
using System.Linq;

namespace Review.App
{
 
    public class Management //management class
    {
        private Dictionary<string, Product> products= new Dictionary<string, Product>(); //dictionary
      
        public void AddProduct(Product product)
        {
            if (products.ContainsKey(product.ProductCode))
            {
                throw new Exception("Duplicate product");
            }
            products.Add(product.ProductCode, product);

        }
        public List<Product> SortedByPriceDesc()    //sort using IComparer<Product>
        {
          
            List<Product> productList = products.Values.ToList();
            productList.Sort(new ProductPriceComparer());
            return productList;
        }
        public Product GetProd(string productCode)
        {
            if (products.ContainsKey(productCode)){
                return products[productCode];
            }
            throw new Exception("product not found");
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
