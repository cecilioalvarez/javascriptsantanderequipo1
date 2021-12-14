namespace net.Models
{

    public class Factura
    {


        public string Concepto { get; set; }
        public int Numero { get; set; }
        public double Importe { get; set; }
        
        public Factura(int Numero, string Concepto, double Importe)
        {

            this.Numero = Numero;
            this.Concepto = Concepto;
            this.Importe = Importe;
            


        }
        public Factura()
        {


        }

    }
}     