using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.CumplimientoLSP
{
    public class Cuadrados : FigurasGeometrica
    {
        private double lado;

        public Cuadrados(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularAreas()
        {
            return lado * lado;
        }
    }
}
