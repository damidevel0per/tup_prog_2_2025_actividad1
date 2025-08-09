using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadAula.Models
{
    internal class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return (Radio * Radio) * Math.PI;
        }

        public string Descripcion()
        {
            return
$@"
{{ 
""Tipo"": ""Circulo"", 
""Radio"": {Radio.ToString("0.00", CultureInfo.InvariantCulture)}, 
""Area"": {CalcularArea().ToString("0.00", CultureInfo.InvariantCulture)}
}}";
        }
    }
}
