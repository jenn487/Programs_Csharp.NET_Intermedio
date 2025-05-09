using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DIP
{
    class CustomerRepository : ICustomerRepository
    {
        public string GetCustomerData() => "Datos del cliente obtenidos...";
    }
}
