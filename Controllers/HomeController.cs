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

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cursosantander;";
            // Tu consulta en SQL
            string query = "SELECT * from Facturas";
            List<string> lista = new List<string>();
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                databaseConnection.Open();
                MySqlDataReader reader;


                // Ejecuta la lectura de la primera fila de la tabla
                reader = commandDatabase.ExecuteReader();
                //reader.Read();
                //ViewBag.concepto = reader.GetString("concepto");
                //ViewBag.importe = reader.GetDecimal("importe");
                //ViewBag.numero = reader.GetInt32("numero");



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetInt32("numero")+"\t"+reader.GetString("concepto")+"\t"+reader.GetDecimal("importe"));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ViewBag.lista = lista;
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
}
