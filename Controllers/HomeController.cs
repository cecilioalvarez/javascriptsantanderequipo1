using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using javascriptsantanderequipo1.Models;
using MySql.Data.MySqlClient;


namespace javascriptsantanderequipo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            @ViewBag.datos = DataBase.MostrarTabla();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult InsertarDispositivo()
        {
            return View();
        }
        public IActionResult Borrar(int numero)
        {
            DataBase.BorrarDispositivo(numero);
            return RedirectToAction("Index");
        }
        public IActionResult Insertar(string concepto, decimal importe)
        {
            DataBase.InsertarDispositivo(new ClaseFactura(concepto, importe));
            return RedirectToAction("Index");
        }

        public IActionResult Detalles(int numero)
        {
            @ViewBag.detalles = DataBase.MostrarDetalles( numero);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
