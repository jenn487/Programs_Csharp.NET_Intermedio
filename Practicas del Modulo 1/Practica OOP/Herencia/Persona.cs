
namespace Practica_OOP.Herencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }
        public void mostrarPersona() // metodo para mostrar la info de la persona
        {
            Console.WriteLine($"Estudiante {Nombre}, con {CalcularEdad()} de {Ciudad}");
        }

        public int CalcularEdad() //metodo para calcular la edad segun el año
        {
            return Edad = 2025 - Edad;
        }

    }

}

