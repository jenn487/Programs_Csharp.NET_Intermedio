using Practica_DIP;

class Program
{   /*Mandato de la tarea: Crear una clase CustomerService que depende de una clase CustomerRepository 
     * para acceder a datos de clientes. La clase CustomerService crea una instancia de CustomerRepository en su constructor.
     * 
     * Problema: Como puede ver esta dependencia directa dificulta las pruebas unitarias y limita la flexibilidad del código.
     * 
     * Con la descripcion de la tarea CustomerService depende directamente de CustomerRepository, lo que significa que si 
     * se quiere cambiar la forma de acceder a los datos, habria que modificar CustomerService. Eso dificulta la prueba unitaria, 
     * ya que puede reemplazar facilmente CustomerRepository con una version falsa para pruebas.
     */

    static void Main()
    {
        // uso de el repositorio real
        ICustomerRepository realRepository = new CustomerRepository();
        CustomerService servicioReal = new CustomerService(realRepository);
        servicioReal.ShowCustomerData();

        // uso de un repositorio simulado para pruebas
        ICustomerRepository mockRepository = new MockRepository();
        CustomerService servicioPrueba = new CustomerService(mockRepository);
        servicioPrueba.ShowCustomerData();
 
    }
    /*Para corregirlo, utilizo la interfaz ICustomerRepository que define como acceder a los datos de clientes. 
     * Luego CustomerService dependera de la interfaz no de una clase concreta como decia el mandato al inicio.
     */

}
