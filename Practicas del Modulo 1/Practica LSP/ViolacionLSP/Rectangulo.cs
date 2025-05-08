using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.ViolacionLSP
{
    internal class Rectangulo: FiguraGeometrica
    {
        public Rectangulo(double base_, double altura) : base(base_, altura)
        {
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
