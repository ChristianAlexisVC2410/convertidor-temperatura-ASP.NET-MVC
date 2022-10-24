using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903Web_convertidor.Models
{
    public class Convertidor
    {
        public double Numero { get; set; }
        public double Resultado {get;set;}

        public void convertirFahrenheit()
        {
            this.Resultado = this.Numero* 9/5 +32;
        }

        public void convertirCelcious()
        {
            this.Resultado = (this.Numero -32)* 5/9;
        }

    }
}