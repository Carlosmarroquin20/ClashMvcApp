using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;                   
using ClashMvcApp.Models;

namespace ClashMvcApp.Controllers
{
    public class CartaController : Controller
    {
        private readonly List<Carta> _cartas = new()
        {
            new Carta(1, "Arqueras", "Comun"),
            new Carta(2, "Caballero", "Comun"),
            new Carta(3, "Gigante", "Especial"),
            new Carta(4, "Mago", "Especial"),
            new Carta(5, "Tesla", "Comun")
        };

        // GET: /Carta
        public IActionResult Index()
        {
            return View(_cartas);
        }

        // GET: /Carta/Details/3
        public IActionResult Details(int id)
        {
            var carta = _cartas.FirstOrDefault(c => c.Id == id);
            if (carta == null)
            {
                return NotFound();
            }
            return View(carta);
        }
    }
}
