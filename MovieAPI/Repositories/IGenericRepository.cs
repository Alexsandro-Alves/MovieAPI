using System;
using System.Collections.Generic;

namespace MovieAPI.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Save();
        void Create(T entity);
        void Update(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
