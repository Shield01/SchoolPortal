using Core.Models;
using Infrastructure.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.ConcreteImplementations
{
    public class BaseEntityRepository<T> : IBaseEntityRepository<T> where T : BaseEntity
    {
        private readonly ProjectDbContext _dbContext;
        public BaseEntityRepository(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T Create(T newObject)
        {
            newObject.DateCreated = DateTime.Now;
            newObject.DateModified = DateTime.Now;
            _dbContext.Add(newObject);
            _dbContext.SaveChanges();
            return newObject;
        }

        public void Delete(T oldObject)
        {
            _dbContext.Remove(oldObject);
            _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            var result = _dbContext.Set<T>().Find(id);
            return result;
        }

        public IEnumerable<T> GetAll()
        {
            var result = _dbContext.Set<T>();
            return result;
        }

        public T Update(int id, T newObject)
        {
            _dbContext.Entry(newObject).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return newObject;


            //var result = Get(id);
            //result.DateModified = DateTime.Now;
            //result.
        }
    }
}
