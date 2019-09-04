using System;
using School.Common.Enums;

namespace School.Service.Core.DTO.School.Teacher
{
    public class UpdateTeacherDTO
    {
        public Guid Id { get; set; }
        public Guid SchoolId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public TeacherStatus Status { get; set; }
    }
}
