using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstractions
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAll();

        public Student Get(int id);

        public Student Create(Student newObject);

        public Student Update(int id, Student newObject);

        public void Delete(Student oldObject);
    }
}
