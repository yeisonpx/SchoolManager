using System;
namespace School.Domain.Calendar
{
    public class ScheduleDetail : Entity
    {
        public Guid ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DayOfWeek Day { get; set; }
        public Guid SectionId { get; set; }
        public Section Section { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid SignatureId { get; set; }
        public SchoolSignature Signature { get; set; }
    }
}
