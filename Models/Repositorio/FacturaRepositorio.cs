using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace javascriptsantanderequipo1.Models

{
    public class FacturaRepository {

        public List<Factura> BuscarTodos() {


            string connectionString = "datasource=localhost;port=8889;username=root;password=root;database=cursosantander;";
                // Tu consulta en SQL
                string query = "SELECT * from Facturas";
                List<Factura> lista= new List<Factura>();
            
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    databaseConnection.Open();
                    MySqlDataReader reader;
                    reader = commandDatabase.ExecuteReader();
                    while (reader.Read()) {
                        
                        Factura factura= new Factura(reader.GetInt32("Numero"),reader.GetString("concepto"),reader.GetDecimal("Importe"));
                        lista.Add(factura);
                    }

                return lista;

        }

    }

