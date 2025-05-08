using System;
using Practica_LSP.CumplimientoLSP;
using Practica_LSP.ViolacionLSP;

class Program
{
    static void Main()
    {
        Console.WriteLine("------- A CONTINUACION, DOS DEMOSTRACIONES DE LSP ---------");
        //Violacion del LSP
        Console.WriteLine(">> Implementacion incorrecta de SLP");
        FiguraGeometrica rectangulo = new Rectangulo(4, 5);
        FiguraGeometrica cuadrado = new Cuadrado(4);

        Console.WriteLine("Area del rectangulo: " + rectangulo.CalcularArea()); 
        Console.WriteLine("Area del cuadrado: " + cuadrado.CalcularArea());    

        cuadrado.Base = 5; // Cambia solo una dimensión en un cuadrado
        Console.WriteLine("Area del cuadrado modificado: " + cuadrado.CalcularArea());
        Console.WriteLine("");


        //Cumplimiento del LSP
        Console.WriteLine(">> Implementacion correcta de SLP");
        FigurasGeometrica rectangulos = new Rectangulos(4, 5);
        FigurasGeometrica cuadrados = new Cuadrados(4);

        Console.WriteLine("Area del rectangulo: " + rectangulos.CalcularAreas()); 
        Console.WriteLine("Area del cuadrado: " + cuadrados.CalcularAreas());

        // Ahora no se puede modificar el lado o la base,altura desde fuera y asi se evita el error logico
        //Los objetos de una superclase deben poder ser reemplazados por objetos de sus subclases sin afectar la correccion del programa
    }
}
