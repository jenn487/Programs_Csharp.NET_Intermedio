using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DIP
{
    class MockRepository : ICustomerRepository
    {
        public string GetCustomerData() => "Datos simulados del cliente...";
    }
}
