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

            FacturaRepository repositorio = new FacturaRepository();
            List<Factura> listaFacturas=repositorio.BuscarTodos();
            ViewBag.listaFacturas=listaFacturas;

            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Insertar(Factura factura)
        {
            FacturaRepository repositorio= new FacturaRepository();
            repositorio.Insertar(factura);
            List<Factura> listaFacturas=repositorio.BuscarTodos();
            ViewBag.listaFacturas=listaFacturas;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
