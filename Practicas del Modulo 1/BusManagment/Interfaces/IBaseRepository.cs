using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusManagement.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetById(int id);
        List<T> GetAll();
        List<T> Find(Expression<Func<T, bool>> predicate);
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity) => _entities.Add(entity);
        public void Update(T entity) { /* logic de actualizacion */ }
        public void Remove(T entity) => _entities.Remove(entity);
        public T GetById(int id) => _entities.FirstOrDefault();
        public List<T> GetAll() => _entities;
        public List<T> Find(Expression<Func<T, bool>> predicate) => _entities.AsQueryable().Where(predicate).ToList();
    }
}
