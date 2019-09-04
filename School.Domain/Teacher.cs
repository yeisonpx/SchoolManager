using System;
using System.Collections.Generic;

namespace School.Domain
{
    public class Teacher : Entity
    {
        public Guid SchoolId { get; set; }
        public School School { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public TeacherStatus Status { get; set; }
        public IEnumerable<SchoolSignature> Signatures { get; set; }
    }
}
