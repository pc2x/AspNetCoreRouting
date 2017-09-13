using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Users.Controllers
{
    [Site("Users")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.controller = "Users/Home";
            return View();
        }
    }
}