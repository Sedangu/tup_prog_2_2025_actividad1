using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_solo.Models.Class
{
    internal class Rectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            Largo = largo;
            Ancho = ancho;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"
{{ 
  ""Tipo"": ""Rectangulo"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }

    }
}
