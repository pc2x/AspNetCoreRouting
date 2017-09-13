using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Admin.Areas.Cards.Controllers
{
    [Site("Admin")]
    [Area("Cards")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}