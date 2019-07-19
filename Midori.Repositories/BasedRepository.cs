using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Midori.Domain.Models;
using Midori.Repositories.Interfaces;

namespace Midori.Repositories
{
    public class BasedRepository<T> : IBasedRepository<T>
        where T : class
    {
        private readonly DbContext _entities;
        public BasedRepository(DbContext entities)
        {
            _entities = entities;
        }

        public IEnumerable<T> FindAll()
        {
            return _entities.Set<T>().AsEnumerable();
        }

        public T FindDetail(object id)
        {
            return _entities.Set<T>().Find(id);
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _entities.Set<T>().Where(expression).AsEnumerable();
        }

        public void Create(T entity)
        {
            _entities.Set<T>().Add(entity);
            _entities.Entry(entity).State = EntityState.Added;
        }

        public void Update(T entity)
        {
            _entities.Set<T>().Attach(entity);
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
            _entities.Entry(entity).State = EntityState.Deleted;
        }

        public async Task SaveAsync()
        {
            await _entities.SaveChangesAsync();
        }
    }
}
