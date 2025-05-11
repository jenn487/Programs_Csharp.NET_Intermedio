using BusManagement.Entities;
using BusManagement.Interfaces;
using BusManagement.Repository;
/* aqui se realizo refactoring del un codigo utilizando generics
 * es como una botella puede contener agua, jugo, cocacola o cafe, pero su 
 * estructura no cambia solo el liquido dentro.
 * con generics podriamos crear una clase generica Botella<T> donde T representa cualquier tipo de bebida.
 */
class Program
{
    static void Main()
    {
        IAsientoRepository asientoRepo = new AsientoRepository();

        // anadir asientos utilizo conversion implicita
        asientoRepo.Add(new Asiento { AsientoId = 1, BusId = 101, NumeroPiso = 1, NumeroAsiento = 5, FechaCreacion = DateTime.Now });
        asientoRepo.Add(new Asiento { AsientoId = 2, BusId = 101, NumeroPiso = 1, NumeroAsiento = 10, FechaCreacion = DateTime.Now });

        // Obtener todos los asientos
        var todos = asientoRepo.GetAll();

        // filtro de asientos por BusId
        var asientosBus101 = asientoRepo.ObtenerPorBus(101);

        // ver resultados
        Console.WriteLine($"Total de Asientos: {todos.Count}");
        Console.WriteLine($"Asientos en Bus 101: {asientosBus101.Count}");
    }
}
