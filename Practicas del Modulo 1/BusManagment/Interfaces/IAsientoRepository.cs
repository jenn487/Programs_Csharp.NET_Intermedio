using BusManagement.Entities;
using BusManagement.Repository;

namespace BusManagement.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento>
    {
        List<Asiento> ObtenerPorBus(int busId);
    }
}
