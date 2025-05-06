using Practica_OOP.Herencia;
using Practica_OOP.Polimorfismo;

namespace Practica_OOP
{
    public class Program
    {
        static void Main()
        {
            /*entrada y lectura de texto para la parte
             * de herencia para la clase Persona
             */

            Console.WriteLine("Hola, ¿cual es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿En que año naciste?");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿De que ciudad eres?");
            string ciudad = Console.ReadLine();

            Console.WriteLine("¿Que estudia?");
            string carrera = Console.ReadLine();

            Console.WriteLine("¿Cual es tu matricula?");
            string matricula = Console.ReadLine();

            Console.Clear();
            Estudiante estudiante = new Estudiante(nombre, edad, ciudad, carrera, matricula);
            estudiante.mostrarTodo();

            /*entrada y lectura de texto para la parte
            * de Polimorfismo para la clase Figura
            */

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Precione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("A continuacion veras las areas calculadas de figuras geometricas");
            Console.WriteLine("Rectangulo(5, 3) - Circulo(2.5) - Triangulo(4, 6)");
            Console.WriteLine("-------------------------------------------------------------------------");
            Figura rect = new Rectangulo(5, 3);
            Figura circ = new Circulo(2.5);
            Figura tri = new Triangulo(4, 6);

            Console.WriteLine($"\nÁrea del rectángulo: {rect.CalcularArea()}");
            Console.WriteLine($"Área del círculo: {circ.CalcularArea()}");
            Console.WriteLine($"Área del triángulo: {tri.CalcularArea()}");


        }
    }
}
