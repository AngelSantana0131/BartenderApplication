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

        [HttpPost]
        public ActionResult OrderDrink(Order order)
        {
            if(ModelState.IsValid)
            {
                repository.SaveOrder(order);
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
