using Core.Models;
using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepo;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepo = studentRepository;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var result = _studentRepo.GetAll();
            return result;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
           var result = _studentRepo.Get(id);
            return result;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student newObject)
        {
            _studentRepo.Create(newObject);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student newObject)
        {
            _studentRepo.Update(id, newObject);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var oldObject = Get(id);
            _studentRepo.Delete(oldObject);
        }
    }
}
