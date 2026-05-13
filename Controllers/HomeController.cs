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

     public IActionResult Resultado(string nombre, DateTime fechaNacimiento, string tipoComida, double presupuesto, int cantidadPersonas)
    {
        Receta receta = new Receta();
        receta.nombre = nombre;
        receta.fechaNacimiento = fechaNacimiento;
        receta.tipoComida = tipoComida;
        receta.presupuesto = presupuesto;
        receta.CantidadPersonas = CantidadPersonas;

        ViewBag.Nombre = receta.nombre;
        ViewBag.Edad = receta.CalcularEdad();
        ViewBag.Plato = receta.DeterminarPlato();
        ViewBag.Tiempo = receta.CalcularTiempo();
        ViewBag.Dificultad = receta.DeterminarDificultad();
        ViewBag.CantidadPersonas = receta.CantidadPersonas

        return View("Resultado");
    }
    *
}
