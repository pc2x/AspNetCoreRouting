using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Admin.Controllers
{
    [Site("Admin")]
    //[Route("Admin/[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.controller = "Admin/Home";
            return View();
        }
    }
}