using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP.ViolacionLSP
{
    public class FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public FiguraGeometrica(double base_, double altura) 
        {
            Base = base_;
            Altura = altura;
        }
        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
