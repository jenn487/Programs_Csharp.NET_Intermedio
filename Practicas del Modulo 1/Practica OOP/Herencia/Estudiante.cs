using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_OOP.Herencia
{
    public class Estudiante : Persona //herencia e la clase perona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
            : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public void mostrarTodo()
        {
            Console.WriteLine($"Hola, el estudiante es {Nombre}, tiene {CalcularEdad()} años y es de {Ciudad}");
            Console.WriteLine($"Pertenece a la carrera de {Carrera}, con matricula {Matricula}.");

        }
    }
}
