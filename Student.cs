using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInheritance
{
    public class Student : Person
    {
        public Student(string Name, int Age, string studentid, string email)
        : base(Name, Age)
        {
            this.StudentId = studentid;
            this.Email = email;
        }
        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}
