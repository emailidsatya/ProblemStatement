using ProblemStatement_PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemStatement_PromotionEngine.Controllers
{
    public class ShoppingController : Controller
    {
        ProductModel _objProductModel = new ProductModel();
        CartModel _objCart = new CartModel();
        // GET: Shopping
        public ActionResult Index()
        {
            
            ViewBag.productList = _objProductModel.getAllProductList();
            return View();
          
        }
        public ActionResult AddToCart(string id)
        {

            var productDetails = _objProductModel.getProductById(Convert.ToInt32(id));


            if (Session["cart"] == null)
            {
                List<CartModel> cart = new List<CartModel>();
                cart.Add(new CartModel { CartId = cart.Count + 1, ProductId = productDetails.Id, Quantity = 1 });
                _objCart.CartList = cart;
                Session["cart"] = cart;
            }
            else
            {
                List<CartModel> cart = (List<CartModel>)Session["cart"];
                int index = isExist(productDetails.Id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartModel { CartId = cart.Count + 1, ProductId = productDetails.Id, Quantity = 1 });
                }
                _objCart.CartList = cart;
                Session["cart"] = cart;
            }

            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<CartModel> cart = (List<CartModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].ProductId == id)
                    return i;
            return -1;
        }
    }
}