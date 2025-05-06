using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP.Country
{
    public class UKTaxStrategy : ITaxStrategy
    {
        public string CodigoPais => "UK";

        public decimal Calculate(decimal ingreso, decimal deduccion)
        {
            decimal taxableingreso = ingreso - deduccion;

            if (taxableingreso <= 12570)
                return 0;
            else if (taxableingreso <= 50270)
                return (taxableingreso - 12570) * 0.2m;
            else if (taxableingreso <= 150000)
                return 7540 + (taxableingreso - 50270) * 0.4m;
            else
                return 47432 + (taxableingreso - 150000) * 0.45m;
        }
    }
}
