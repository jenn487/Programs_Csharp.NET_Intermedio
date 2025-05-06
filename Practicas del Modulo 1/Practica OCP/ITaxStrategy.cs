using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    public interface ITaxStrategy // Interfaz define el contrato para los calculos de impuestos por country
    {
        decimal Calculate(decimal ingreso, decimal deduccion);
        string CodigoPais { get; }
    }
}
