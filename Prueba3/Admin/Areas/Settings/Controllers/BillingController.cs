using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Admin.Areas.Settings.Controllers
{
    [Site("Admin")]
    [Area("Settings")]
    public class BillingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}