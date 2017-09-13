using Microsoft.AspNetCore.Mvc;

namespace Prueba3.Users.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}