using Microsoft.AspNetCore.Mvc;
using MIS3033_HW5.Data;
using MIS3033_HW5.Models;

namespace MIS3033_HW5.Controllers
{
    public class HomeController : Controller
    {
        DbConnect db = new DbConnect();
        public IActionResult Index(string numMouses, string numPads)
        {
            if (numMouses != null || numPads != null)
            {
                int numMousesInt = Convert.ToInt32(numMouses);
                int numPadsInt = Convert.ToInt32(numPads);
                double subtotal = 39.99 * numMousesInt + 19.99 * numPadsInt;

                Order order = new Order() { NumMouses=numMousesInt,NumPads=numPadsInt,Subtotal=subtotal};
                db.Orders.Add(order);
                db.SaveChanges();
            }
            return View();
        }
        public IActionResult Show()
        {
            List<Order> orderList = db.Orders.ToList();

            return View(orderList);
        }
    }
}
