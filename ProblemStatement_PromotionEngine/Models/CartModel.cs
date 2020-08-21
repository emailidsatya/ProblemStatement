using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProblemStatement_PromotionEngine.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
        public List<CartModel> CartList { get; set; }
    }
}