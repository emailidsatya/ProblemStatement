using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemStatement_PromotionEngine.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public List<ProductModel> productList = new List<ProductModel>();

        // private List<Product> products;

       

        public List<ProductModel> getAllProductList()
        {
            List<ProductModel> productList = new List<ProductModel>()
            {
                new ProductModel{Id = 1,ProductName = "A",Price = 50},
                new ProductModel{Id = 2,ProductName = "B",Price = 30},
                new ProductModel{Id = 3,ProductName = "C",Price = 20},
                new ProductModel{Id = 4,ProductName = "D",Price = 10},
            };
            return productList;
        }
        public  ProductModel getProductById(int productId)
        {
           return (from u in getAllProductList()
                   where u.Id == productId
                   select u).FirstOrDefault();
        }
    }
}