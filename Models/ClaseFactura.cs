using System.Collections.Generic;
namespace javascriptsantanderequipo1.Models {
    public class ClaseFactura {
        // Variables.
        public int numero { get; set; }
        public string concepto { get; set; }
        public decimal importe { get; set; }

        // Constructor.
        public ClaseFactura(int numero, string concepto, decimal importe) {     
            this.numero = numero;               
            this.concepto = concepto;   
            this.importe = importe;   
        }                                   
    }
}