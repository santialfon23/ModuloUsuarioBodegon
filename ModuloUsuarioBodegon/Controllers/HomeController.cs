using Microsoft.AspNetCore.Mvc;

namespace ModuloUsuarioBodegon.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index -> portada
        public IActionResult Index()
        {
            return View();
        }
    }
}
