using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClashMvcApp.Models;

namespace ClashMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Pagina principal de index
    public IActionResult Index()
    {
        ViewData["Mensaje"] = "Bienvenido al catalogo de Clash Royale By Ema322";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
