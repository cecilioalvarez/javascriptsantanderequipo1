using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace javascriptsantanderequipo1.Models {
    public class DataBase {
        // Constructor
        public DataBase(){}

        public static List<ClaseFactura> MostrarTabla() {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cursosantander;";
            // Consulta en SQL
            string query = "SELECT * FROM Facturas;";
            // Prepara la conexión
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            List<ClaseFactura> datos = new List<ClaseFactura>();
            try {
                // Abre la base de datos
                databaseConnection.Open();

                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();
                
                if (reader.HasRows) {
                    while (reader.Read()) {
                        // Lee cada fila.
                        datos.Add(new ClaseFactura (Convert.ToInt32(reader.GetString(0)),reader.GetString(1),Convert.ToDecimal(reader.GetString(2))));
                    }         
                }
                else {
                    Console.WriteLine("No se encontraron datos.");
                }
                
                // Cerrar la conexión
                databaseConnection.Close();
                return datos;
            } catch (Exception ex) {
                // Mostrar cualquier excepción
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
                return datos;                
            }
        }                                   
    }
}