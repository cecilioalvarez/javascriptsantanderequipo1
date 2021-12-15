using System;
using net.Models;
using System.Collections.Generic;



namespace net.Models.Repositorios
{

    public class FacturaRepositorio
    {


        private  static List<Factura> Lista { get; set; }
        static FacturaRepositorio()
        {

            Lista = new List<Factura>();
           
        }
        public static void Insertar(Factura factura)
        {

            Lista.Add(factura);
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
        
            
        }
        public static List<Factura> BuscarTodos()
        {

            return Lista;
        }
    }
}