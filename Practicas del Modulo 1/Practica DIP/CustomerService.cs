using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DIP
{
    class CustomerService
    {
        private ICustomerRepository repository;  //Dependencia en la abstraccion

        public CustomerService(ICustomerRepository repository)  // Inyeccion dependencias
        {
            this.repository = repository;
        }

        public void ShowCustomerData()
        {
            Console.WriteLine(repository.GetCustomerData());
        }
    }
}
