using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.ViolacionLSP
{
    public class Cuadrado : FiguraGeometrica
    {
        public Cuadrado(double lado) : base(lado, lado)
        {
        }

        // Viola LSP porque no respeta el comportamiento esperado
        public override double CalcularArea()
        {
            return Base * Altura * 0.5; 
        }

    }
}
