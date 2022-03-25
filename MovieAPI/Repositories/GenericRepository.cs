using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        protected GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public T GetById(Guid id)
        {
            return Query().SingleOrDefault(entity => entity.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return Query().ToList();
        }

        public void Save() => _dbContext.SaveChanges();

        protected IQueryable<T> Query() => _dbSet.Where(entity => !entity.Deleted);
    }
}
