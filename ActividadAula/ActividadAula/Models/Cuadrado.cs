using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadAula.Models
{
    internal class Cuadrado
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Cuadrado(double lado)
        {
            Ancho = lado;
            Largo = lado;
        }

        public double CalcularArea()
        {
            return Ancho * Largo;
        }

        public string Describir()
        {
            return
$@"
{{ 
""Tipo"": ""Cuadrado"", 
""Largo"": {Largo.ToString("0.00", CultureInfo.InvariantCulture)}, 
""Ancho"": {Ancho.ToString("0.00", CultureInfo.InvariantCulture)}, 
""Area"": {CalcularArea().ToString("0.00", CultureInfo.InvariantCulture)}
}}";
        }
    }
}
