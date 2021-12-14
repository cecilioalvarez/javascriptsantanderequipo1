namespace javascriptsantanderequipo1.Models {
    public class ClaseFactura {
        // Variables.
        private int numero { get; set; }
        private string concepto { get; set; }
        private decimal importe { get; set; }

        // Constructor.
        public ClaseFactura() {}
        public ClaseFactura(int numero, string concepto, decimal importe) {     
            this.numero = numero;               
            this.nombre = nombre;   
            this.importe = importe;   
        }                                   
    }
}