using Practica_ISP.Clases;

class Program
{
    static void Main()
    {
        Loro loro = new Loro();
        Pato pato = new Pato();
        Pinguino pinguino = new Pinguino();

        Console.WriteLine("\n>> Hola, soy un Loro:");
        loro.Cantar();
        loro.PonerHuevo();
        loro.Cazar();
        loro.Volar();
        loro.Caminar();
        loro.Trepar();

        Console.WriteLine("\n>> Hola, soy un Pato:");
        pato.Cantar();
        pato.PonerHuevo();
        pato.Cazar();
        pato.Volar();
        pato.Trepar();

        Console.WriteLine("\n>> Hola, soy un Pinguino:");
        pinguino.Cantar();
        pinguino.PonerHuevo();
        pinguino.Nadar();
        pinguino.Cazar();
        pinguino.Caminar();
        pinguino.Trepar();
        pinguino.Flotar();
    }
}
