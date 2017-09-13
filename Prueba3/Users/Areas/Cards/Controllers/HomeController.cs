using Microsoft.AspNetCore.Mvc;
using Prueba3.Shared;

namespace Prueba3.Users.Areas.Cards.Controllers
{
    [Site("Users")]
    [Area("Cards")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}