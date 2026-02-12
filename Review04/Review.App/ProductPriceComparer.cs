  namespace Review.App{
  public class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
     
            return y.Price.CompareTo(x.Price);

        }
    }
  }