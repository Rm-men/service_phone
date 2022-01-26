using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public partial class Product
    {
        public class ProductInfo
        {
            public string IdProduct { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int? Counts { get; set; }
        }
/*        public static List<ProductInfo> GettInfo()
        {
            return (from p in Context.Db2.Products
                    select new ProductInfo()
                    {
                        IdProduct = p.IdProduct,
                        Name = p.Name,
                        Price = p.Price,
                        Counts = p.Counts
                    }).ToList();
        }*/
        public static List<Product> GetProducts()
        {
            return (from p in Context.Db2.Products
                    select new Product()
                    {
                        IdProduct = p.IdProduct,
                        Name = p.Name,
                        Price = p.Price,
                        Counts = p.Counts
                    }).ToList();
        }
        public static Product GettProduct(string IdProduct)
        {
            return Context.Db2.Products.Where(a => a.IdProduct == IdProduct).FirstOrDefault();
        }
    }
}
