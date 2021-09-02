using BartenderApplication.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApplication.Models;

namespace BartenderApplication.Controllers
{
    public class MenuController : Controller
    {
        private IMenuRepository repository;
        public MenuController(IMenuRepository repo)
        {
            repository = repo;
        }

        public ViewResult Menu() => View(repository.MenuItems);

    }

}
