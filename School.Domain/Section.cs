using System;
using School.Common.Enums;

namespace School.Domain
{
    public class Section: Entity
    {
        public Guid SchoolId { get; set; }
        public School School { get; set; }
        public string Code { get; set; }
        public string MaxStudentsCapacity { get; set; }
        public SectionStatus Status { get; set; }
    }
}
