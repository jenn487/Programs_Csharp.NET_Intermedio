using Practica_SRP;

namespace Practica_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Jennifer", 21, "Calle mariposa, esquina B miraflores", "carlos@email.com");
            persona.ImprimirDatos();

            Correo servicioCorreo = new Correo();
            servicioCorreo.EnviarCorreo(persona.CorreoElectronico, "Hola Carlos, felicidades has pasaso a la siguiente etapa.");
        }
    }

}
