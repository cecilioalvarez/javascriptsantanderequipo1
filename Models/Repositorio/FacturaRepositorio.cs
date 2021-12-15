using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace javascriptsantanderequipo1.Models

{
    public class FacturaRepository
    {

        public List<Factura> BuscarTodos()
        {


            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;SslMode=none";
            // Tu consulta en SQL
            string query = "SELECT * from Facturas";
            List<Factura> lista = new List<Factura>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {

                Factura factura = new Factura(reader.GetInt32("Numero"), reader.GetString("concepto"), reader.GetDecimal("Importe"));
                lista.Add(factura);
            }

            return lista;

        }
        public void Insertar(Factura f)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;SslMode=none";

            string query = "insert into Facturas values (" + f.Numero + ", '" + f.Concepto + "'," + f.Importe + ")";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
        }

        public void Borrar(Factura f)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;database=cursosantander;SslMode=none";

            string query = "delete from Facturas where numero='" + f.Numero + "'";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
        }

    }

}

