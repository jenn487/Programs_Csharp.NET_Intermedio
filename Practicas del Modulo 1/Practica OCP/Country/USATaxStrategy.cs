using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP.Country
{
    public class USATaxStrategy : ITaxStrategy
    {
        public string CodigoPais => "USA";

        public decimal Calculate(decimal ingreso, decimal deduccion)
        {
            decimal taxableingreso = ingreso - deduccion;

            if (taxableingreso <= 9950)
                return taxableingreso * 0.1m;
            else if (taxableingreso <= 40525)
                return 995 + (taxableingreso - 9950) * 0.12m;
            else if (taxableingreso <= 86375)
                return 4664 + (taxableingreso - 40525) * 0.22m;
            else
                return 14751 + (taxableingreso - 86375) * 0.24m;
        }
    }
}
