using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using javascriptsantanderequipo1.Models;


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
            List<Factura> listaFacturas = repositorio.BuscarTodos();
            ViewBag.listaFacturas = listaFacturas;

            return View();
        }
        // borrar
        public IActionResult PruebaIndex()
        {

            FacturaRepository repositorio = new FacturaRepository();
            List<Factura> listaFacturas = repositorio.BuscarTodos();
            ViewBag.listaFacturas = listaFacturas;

            return View();
        }
        public IActionResult PruebaFormulario()
        {
            return View();
        }
        public IActionResult Formulario()
        {
            return View();
        }
        public IActionResult Insertar(Factura factura)
        {
            FacturaRepository repositorio = new FacturaRepository();
            repositorio.Insertar(factura);
            List<Factura> listaFacturas = repositorio.BuscarTodos();
            ViewBag.listaFacturas = listaFacturas;
            return View("PruebaIndex");
        }
        public IActionResult Detalle(int numero)
        {
            ViewBag.Numero = numero;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       /* public IActionResult BorrarFactura(int numero)
        {
            FacturaRepository.BorrarUna(numero);
            //ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return RedirectToAction("PruebaIndex", "Home");
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
