using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadAula.Models
{
    internal class Cubo
    {
        public Cuadrado[] Caras = new Cuadrado[6];

        public Cubo(double lado)
        {
            Caras[0] = new Cuadrado(lado);
            Caras[1] = new Cuadrado(lado);
            Caras[2] = new Cuadrado(lado);
            Caras[3] = new Cuadrado(lado);
            Caras[4] = new Cuadrado(lado);
            Caras[5] = new Cuadrado(lado);
        }

        public double CalcularArea()
        {
            return Caras[0].CalcularArea() * 6;
        }

        public double CalcularVolumen()
        {
            return Caras[0].Ancho * Caras[0].Ancho * Caras[0].Ancho;
        }

        public string Describir()
        {
            string descripcion =
$@"
{{  
""Tipo"": ""Cubo"", 
""Caras"": 
[
{Caras[0].Describir()}, 
{Caras[1].Describir()}, 
{Caras[2].Describir()}, 
{Caras[3].Describir()}, 
{Caras[4].Describir()}, 
{Caras[5].Describir()}

],
""Area"": {CalcularArea().ToString("0.00", CultureInfo.InvariantCulture)},
""Volumen"": {CalcularVolumen().ToString("0.00", CultureInfo.InvariantCulture)}
}}";

            return descripcion;
        
        }

    }
}
