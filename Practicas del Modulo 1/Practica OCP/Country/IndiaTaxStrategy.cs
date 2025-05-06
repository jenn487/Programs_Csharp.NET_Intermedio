namespace Practica_OCP.Country
{
    public class IndiaTaxStrategy : ITaxStrategy
    {
        public string CodigoPais => "India";

        public decimal Calculate(decimal ingreso, decimal deduccion)
        {
            decimal taxableingreso = ingreso - deduccion;

            if (taxableingreso <= 250000)
                return 0;
            else if (taxableingreso <= 500000)
                return (taxableingreso - 250000) * 0.05m;
            else if (taxableingreso <= 1000000)
                return 12500 + (taxableingreso - 500000) * 0.2m;
            else
                return 112500 + (taxableingreso - 1000000) * 0.3m;
        }
    }
}
