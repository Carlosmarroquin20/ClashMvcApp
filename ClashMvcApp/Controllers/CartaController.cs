using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClashMvcApp.Controllers
{
    public class CartaController : Controller
    {
        public IActionResult Index()
        {
            // Lista estática de ejemplo
            var cartas = new List<string>
            {
                "Archers",
                "Knight",
                "Giant",
                "Wizard",
                "Tesla"
            };
            return View(cartas);
        }
    }
}
