using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace javascriptsantanderequipo1.Models


{
    public class FacturaRepository
    {

        private static List<Factura> Lista { get; set; }
        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=cursosantander;";
        public List<Factura> BuscarTodos()
        {

            // Tu consulta en SQL
            string query = "SELECT * from Facturas";
            Lista = new List<Factura>();


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Factura factura = new Factura(reader.GetInt32("Numero"), reader.GetString("concepto"), reader.GetDecimal("Importe"));
                Lista.Add(factura);
            }

            return Lista;
        }

        public static Factura BuscarUna(int numero)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].Numero == numero)
                {
                    return Lista[i];
                }
            }
            return null;
        }
        public void Insertar(Factura f)
        {

            // Tu consulta en SQL
            string query = "insert into Facturas (Concepto, Importe) values  ('" + f.Concepto + "'," + f.Importe + ")";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
        }
  /*public static void BorrarUna(int borrar)
        {
            string query = "DELETE FROM Facturas WHERE Numero = " + borrar.Numero +" ";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();

        }*/

    }

}