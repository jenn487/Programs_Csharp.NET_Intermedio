namespace BusManagement.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
