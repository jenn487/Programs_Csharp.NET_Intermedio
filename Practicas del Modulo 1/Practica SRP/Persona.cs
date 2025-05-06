
namespace Practica_SRP
{
    /* El SRP (Single Responsibility Principle) dice que una clase 
     * debe tener una sola razon para cambiar, quiere decir que debe tener 
     * solo una responsabilidad o funcion. Aqui en el codigo inical persona tenia
     * dos responsabilidades pues manejaba los datos de la persona y tambien enviaba correo
     * por lo que separa persona de la logica de envio de correo para cumplir con el SRP
     */
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("____________________________________________________");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Correo electrónico: {CorreoElectronico}");
            Console.WriteLine("____________________________________________________");

        }

        /*
        public class Persona
        {
            private string nombre;
            private int edad;
            private string direccion;
            private string correoElectronico;
            public void EnviarCorreoElectronico(string mensaje)
            {
                // Lógica para enviar correo electrónico
            }
            public void ImprimirDatos()
            {
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Edad: {edad}");
                Console.WriteLine($"Dirección: {direccion}");
                Console.WriteLine($"Correo electrónico: {correoElectronico}");
            }
        }*/

    }
}
