using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VehicleProject.Data1;

namespace VehicleProject.Persistence
{


    public class Repository<T> : IRepository<T> where T : class
        {
            private readonly VehicleContext _context;
            public Repository(VehicleContext context)
            {
                this._context = context;
            }
            public IEnumerable<T> GetAll()
            {
                return this._context.Set<T>();
            }
            public T GetById(int id)
            {
                return this._context.Set<T>().Find(id);

            }


            public IEnumerable<T> Find(Expression<Func<T, bool>> Predicate)
            {
                return this._context.Set<T>().Where(Predicate);
            }

            public T FirstOrDefault(Expression<Func<T, bool>> Predicate)
            {
                return this._context.Set<T>().FirstOrDefault(Predicate);
            }

            public void Add(T entity)
            {
                this._context.Set<T>().Add(entity);
            }


            public void Remove(T entity)
            {
                this._context.Set<T>().Remove(entity);
            }

            public void Update(T entity)
            {
                this._context.Set<T>().Update(entity);
            }

            
        }
    }
}
