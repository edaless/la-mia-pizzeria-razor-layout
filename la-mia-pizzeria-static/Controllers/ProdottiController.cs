using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class ProdottiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
