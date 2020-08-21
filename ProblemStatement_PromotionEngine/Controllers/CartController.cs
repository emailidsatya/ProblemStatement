using ProblemStatement_PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProblemStatement_PromotionEngine.Controllers
{
    public class CartController : Controller
    {
        ProductModel objProduct = new ProductModel();
        // GET: Cart

        public ActionResult Index()
        {
            List<CartModel> cart = (List<CartModel>)Session["cart"];
            ViewBag.carList = cart;
            return View();
        }
        public ActionResult Remove(string id)
        {
            List<CartModel> cart = (List<CartModel>)Session["cart"];


            var isExits = (from u in cart
                           where u.ProductId == Convert.ToInt32(id)
                           select u).FirstOrDefault();

            if (isExits.Quantity > 1)
            {
                foreach (var item in cart.Where(w => w.ProductId == Convert.ToInt32(id)))
                {
                    item.Quantity = isExits.Quantity - 1;
                }
            }
            else
            {
                cart.Remove(isExits);
            }

            Session["cart"] = cart;
            return RedirectToAction("Index");
        }
    }
}