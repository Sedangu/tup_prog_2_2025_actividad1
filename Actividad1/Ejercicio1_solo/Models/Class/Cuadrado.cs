﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models.Class
{
    internal class Cuadrado
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Cuadrado(double lado)
        {
            Largo = lado;
            Ancho = lado;
        }
        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public string Describir()
        {
            var culture = CultureInfo.InvariantCulture;

            return $@"{{ 
  ""Tipo"":""Cuadrado"", 
  ""Largo"": {Largo.ToString("f2", culture)}, 
  ""Ancho"": {Ancho.ToString("f2", culture)}, 
  ""Area"": {CalcularArea().ToString("f2", culture)}
}}";
        }
        }
}
