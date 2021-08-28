using Core.Models;
using Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ConcreteImplementations
{
    public class StudentRepository : BaseEntityRepository<Student>, IStudentRepository
    {
        public StudentRepository(ProjectDbContext dbContext) : base(dbContext)
        {

        }
    }
}
