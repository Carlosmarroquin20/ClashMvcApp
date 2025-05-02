using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClashMvcApp.Models; 

namespace ClashMvcApp.Controllers
{
    public class CartaController : Controller
    {
        public IActionResult Index()
        {
            // Lista estática de ejemplo
            var cartas = new List<Carta>
            {
                new Carta(1, "Arqueras", "Comun"),
                new Carta(2, "Caballero", "Comun"),
                new Carta(3, "Gigante", "Especial"),
                new Carta(4, "Mago", "Especial"),
                new Carta(5, "Tesla", "Comun"),

            };
            return View(cartas);
        }
    }
}
