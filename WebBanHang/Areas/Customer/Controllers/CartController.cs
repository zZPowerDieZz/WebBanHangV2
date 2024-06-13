using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Helpers;
using WebBanHang.Models;

namespace WebBanHang.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CartController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("CART");
            if( cart == null)
            {
                cart = new Cart();
            }
            return View(cart);
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _db.Products.FirstOrDefault(x => x.Id == productId);
            if(product != null)
            {
                Cart cart = HttpContext.Session.GetJson<Cart>("CART");
                if(cart == null)
                {
                    cart = new Cart();
                }
                cart.Add(product, 1);
                HttpContext.Session.SetJson("CART", cart);
                return RedirectToAction("Index");
                //return Json(new { msg = "success" , qty = cart.Quantity});
            }
            return Json(new { msg = "error" });
        }
    }
}
