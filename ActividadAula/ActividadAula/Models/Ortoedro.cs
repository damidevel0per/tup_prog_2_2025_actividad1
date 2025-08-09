using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace ActividadAula.Models
{
    internal class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];

        public Ortoedro(double anchoBase, double ladoComun, double ladoLateral)
        {
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);

            Laterales[0] = new Rectangulo(ladoComun, ladoLateral);
            Laterales[1] = new Rectangulo(ladoComun, ladoLateral);
            Laterales[2] = new Rectangulo(ladoComun, ladoLateral);
            Laterales[3] = new Rectangulo(ladoComun, ladoLateral);

        }

        public double CalcularArea()
        {
            return (Bases[0].CalcularArea() * 2) + (Laterales[0].CalcularArea() * 4);
        }

        public double CalcularVolumen()
        {
            return Bases[0].CalcularArea() * Laterales[0].Largo;
        }

        public string Describir()
        {
            string descripcion =
$@"
{{  
""Tipo"": ""Ortoedro"", 
""Bases"": 
[
{Bases[0].Describir()}, 
{Bases[1].Describir()}
], 
""Laterales"": 
[
{Laterales[0].Describir()},
{Laterales[1].Describir()},
{Laterales[2].Describir()},
{Laterales[3].Describir()}
],
""Area"": {CalcularArea().ToString("0.00", CultureInfo.InvariantCulture)},
""Volumen"": {CalcularVolumen().ToString("0.00", CultureInfo.InvariantCulture)}
}}";

            return descripcion;
        }
    }
}
