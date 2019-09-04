using System;
namespace School.Domain
{
    public class TeacherSection
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
