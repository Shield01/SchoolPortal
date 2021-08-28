using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstractions
{
    public interface IBaseEntityRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();

        public T Get(int id);

        public T Create(T newObject);

        public T Update(int id, T newObject);

        public void Delete(T oldObject);
    }
}
