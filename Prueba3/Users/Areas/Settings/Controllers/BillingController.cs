using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Users.Areas.Settings.Controllers
{
    [Site("Users")]
    [Area("Settings")]
    public class BillingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}