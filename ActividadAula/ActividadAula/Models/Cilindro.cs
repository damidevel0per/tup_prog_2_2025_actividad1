using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadAula.Models
{
    internal class Cilindro
    {
        public Circulo[] Tapas = new Circulo[2];
        public RectanguloDesarrollado Lado;

        public Cilindro(double radio, double altura)
        {
            Tapas[0] = new Circulo(radio);
            Tapas[1] = new Circulo(radio);
            Lado = new RectanguloDesarrollado(radio, altura);
        }

        public double CalcularArea()
        {
            double area = ((Tapas[0].CalcularArea()) * 2) + Lado.CalcularArea();
            return area;
        }

        public double CalcularVolumen()
        {
            double volumen = Math.PI * (Tapas[0].Radio * Tapas[0].Radio) * Lado.Largo;
            return volumen;
        }

        public string Describir()
        {
            string descripcion =
$@"
{{  
""Tipo"": ""Cilindro"", 
""Tapas"": 
[
{Tapas[0].Descripcion()}, 
{Tapas[1].Descripcion()}
],
""Lado"": {Lado.Describir()},
""Area"": {CalcularArea().ToString("0.00", CultureInfo.InvariantCulture)},
""Volumen"": {CalcularVolumen().ToString("0.00", CultureInfo.InvariantCulture)}
}}";

            return descripcion;
        }


    }
}
