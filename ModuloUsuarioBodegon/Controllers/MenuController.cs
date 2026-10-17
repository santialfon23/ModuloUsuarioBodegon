using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuloUsuarioBodegon.Models;

namespace ModuloUsuarioBodegon.Controllers
{
    public class MenuController : Controller
    {
        private readonly BodegonContext _context;

        public MenuController(BodegonContext context)
        {
            _context = context;
        }

        // GET: /Menu/Index -> carta
        public IActionResult Index()
        {
            // Categorías ordenadas por posición, cada una con sus platos (Include)
            List<Categoria> categorias = _context.Categorias
                .Include(c => c.Platos)
                .OrderBy(c => c.Posicion)
                .ToList();

            return View(categorias);
        }
    }
}
