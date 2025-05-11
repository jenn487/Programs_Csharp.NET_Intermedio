using System.Linq.Expressions;
using BusManagement.Context;
using BusManagement.Interfaces;
using BusManagement.Repository;
using Microsoft.EntityFrameworkCore;

namespace BusManagment.Repository
{
    public class Repository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BusDbContext _context;
        private readonly DbSet<T> _dbSet;

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
