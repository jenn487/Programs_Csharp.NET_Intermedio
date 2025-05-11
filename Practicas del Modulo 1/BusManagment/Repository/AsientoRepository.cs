using BusManagement.Entities;
using BusManagement.Interfaces;
using BusManagement.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusManagement.Repository
{
    public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
    {
        public List<Asiento> ObtenerPorBus(int busId)
        {
            return Find(a => a.BusId == busId);
        }
    }
}
