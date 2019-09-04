using System;
namespace School.Service.Core.DTO.School
{
    public class UpdateSchoolDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
