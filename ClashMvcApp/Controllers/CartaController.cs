using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ClashMvcApp.Models;

namespace ClashMvcApp.Controllers
{
    public class CartaController : Controller
    {
        private readonly List<Carta> _cartas = new()
        {
            new Carta(1, "Arqueras",  "Comun"),
            new Carta(2, "Caballero", "Comun"),
            new Carta(3, "Gigante",   "Especial"),
            new Carta(4, "Mago",      "Especial"),
            new Carta(5, "Tesla",     "Comun")
        };

        // GET: /Carta?rarity=Comun
        public IActionResult Index(string? rarity)
        {
            // 1) Guardamos el filtro para la vista
            ViewData["CurrentRarity"] = rarity ?? "";

            // 2) Filtramos la lista si se pidió una rareza
            var resultado = string.IsNullOrWhiteSpace(rarity)
                ? _cartas
                : _cartas
                    .Where(c => c.Rarity.Equals(rarity, StringComparison.OrdinalIgnoreCase))
                    .ToList();

            return View(resultado);
        }

        // GET: /Carta/Details/3
        public IActionResult Details(int id)
        {
            var carta = _cartas.FirstOrDefault(c => c.Id == id);
            if (carta == null) return NotFound();
            return View(carta);
        }
    }
}
