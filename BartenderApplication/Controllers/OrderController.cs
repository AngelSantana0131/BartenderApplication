using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApplication.Models;

namespace BartenderApplication.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repoService)
        {
            repository = repoService;
        }

        public ViewResult Queue() => View(repository.Orders);

        [HttpPost]
        public ActionResult OrderDrink(Order order, string drinkOrdered)
        {
            if(ModelState.IsValid)
            {
                order.OrderName = drinkOrdered;
                repository.SaveOrder(order);
                return RedirectToAction("Menu", "Menu");
            }
            else
            {
                return RedirectToAction("Menu", "Menu");
            }
        }

        [HttpPost]
        public IActionResult MarkReady(int orderId)
        {
            Order order = repository.Orders.FirstOrDefault(p => p.OrderId == orderId);
            if (order!=null)
            {
                order.DrinkMade = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction("Queue", "Order");
        }

    }

}
