using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public string Religion { get; set; }
        public string Tribe { get; set; }
        public string Complexion { get; set; }
        public string Age { get; set; }
    }
}
