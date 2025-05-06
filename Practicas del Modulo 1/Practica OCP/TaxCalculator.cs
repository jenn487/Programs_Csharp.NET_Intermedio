using Practica_OCP.Country;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OCP
{
    /*esta es la clase principal donde calculadora de impuestos usa las estrategias
     Para strategy para un nuevo país, simplemente se crea nueva
     clase que implemente ITaxStrategy y se registra asi:
     RegisterTaxStrategy(new CanadaTaxStrategy());
     */

    public class TaxCalculator
    {
        private readonly Dictionary<string, ITaxStrategy> _taxStrategies;

        public TaxCalculator()
        {
            // Registrar todas las estrategias de impuestos disponibles
            _taxStrategies = new Dictionary<string, ITaxStrategy>();

            RegisterTaxStrategy(new IndiaTaxStrategy());
            RegisterTaxStrategy(new USATaxStrategy());
            RegisterTaxStrategy(new UKTaxStrategy());

        }

        public void RegisterTaxStrategy(ITaxStrategy taxStrategy)
        {
            _taxStrategies[taxStrategy.CodigoPais] = taxStrategy;
        }

        public decimal Calculate(decimal ingreso, decimal deduccion, string country)
        {
            if (_taxStrategies.TryGetValue(country, out ITaxStrategy taxStrategy))
            {
                return taxStrategy.Calculate(ingreso, deduccion);
            }

            throw new ArgumentException($"Immpuesto para el pais '{country}' no encontrado.", nameof(country));
        }
    }
}
