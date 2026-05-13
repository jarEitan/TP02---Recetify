using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp5.Models;

namespace tp5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

     public IActionResult Resultado(receta receta)
    {
        ViewBag.Nombre = receta.nombre;
        ViewBag.Edad = receta.CalcularEdad();
        ViewBag.Plato = receta.DeterminarPlato();
        ViewBag.Tiempo = receta.CalcularTiempo();
        ViewBag.Dificultad = receta.calcularDificultad();
        ViewBag.cantidadComensales = receta.cantidadComensales;

        return View("Resultado");
    }
}
