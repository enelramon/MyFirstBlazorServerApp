using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirstBlazorServerApp.Data
{

    public  class BaseRepository<T> : IDisposable, IRepository<T> where T : class
    {
        private readonly Context _dataContext;

        public BaseRepository()
        {
            _dataContext = new Context();
        }
        public bool Insert(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            return _dataContext.SaveChanges() > 0;
        }
        public bool Update(T entity)
        {
            _dataContext.Entry<T>(entity).State = EntityState.Modified;
            return _dataContext.SaveChanges() > 0;
        }
        public bool Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
           return _dataContext.SaveChanges()>0;
        }

        public T Get(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }       

        public async Task<IList<T>> ListAsync() 
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public IList<T> List(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).ToList();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
