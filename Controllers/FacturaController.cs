using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using javascriptsantanderequipo1.Models;
using MySql.Data.MySqlClient;

namespace net.Controllers
{
    public class FacturaController : Controller
    {

        public FacturaController()
        {

        }

        public IActionResult Index()
        {
            ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

    }

}