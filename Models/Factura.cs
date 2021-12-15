namespace javascriptsantanderequipo1.Models

{
    public class Factura
    {

        public int Numero { get; set; }
        public string Concepto { get; set; }
        public decimal Importe { get; set; }

        public Factura(int Numero, string Concepto, decimal Importe)
        {
            this.Numero = Numero;
            this.Concepto = Concepto;
            this.Importe = Importe;
        }

    }
}