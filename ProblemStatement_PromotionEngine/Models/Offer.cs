using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemStatement_PromotionEngine.Models
{
    public class Offer
    {
        public int ProductId { get; set; }
        public string OfferName { get; set; }
        public decimal OfferPrice { get; set; }


    }
    public class ProductWiseOffer : Offer
    {
        public decimal productOfferPrice(int productId, decimal offerPrice, int productCount)
        {
            ProductModel obj = new ProductModel();
            if (obj.getProductById(productId) != null)
            {

            }
            return 0;
        }
    }

}