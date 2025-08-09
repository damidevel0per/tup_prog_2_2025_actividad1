using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ActividadAula.Models
{
    internal class Rectangulo
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Rectangulo(double ancho, double largo) 
        {
            Ancho = ancho;
            Largo = largo;
        }

        public double CalcularArea()
        {
            return Ancho * Largo;
        }

        public string Describir()
        {
            return $@"
                            {{ 
                                ""Tipo"": ""Rectangulo"", 
                                ""Largo"": {Largo}, 
                                ""Ancho"": {Ancho}, 
                                ""Area"": {CalcularArea()}
                            }}";
        }
    }
}
