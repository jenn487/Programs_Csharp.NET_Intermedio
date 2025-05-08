using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.CumplimientoLSP
{
    public class Rectangulos : FigurasGeometrica
    {
        private double baseRectangulo;
        private double altura;

        public Rectangulos(double b, double h)
        {
            baseRectangulo = b;
            altura = h;
        }

        public override double CalcularAreas()
        {
            return baseRectangulo * altura;
        }
    }
}
