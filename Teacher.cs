using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInheritance
{
    public class Teacher : Person
    {
        public Teacher (string Name, int Age, string teacherid, string subject)
        :base(Name, Age)
        {
            this.TeacherId = teacherid;
            this.Subject = subject;

        }
        public string TeacherId { get; set; }
        public string Subject { get; set; }
        
       
    }
}
