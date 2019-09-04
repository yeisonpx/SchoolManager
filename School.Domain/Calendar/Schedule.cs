using System;
using System.Collections.Generic;

namespace School.Domain.Calendar
{
    public class Schedule : Entity
    {
        public Guid SchoolId { get; set; }
        public IEnumerable<ScheduleDetail> ScheduleDetails { get; set; }
        public Schedule()
        {
            this.ScheduleDetails = new List<ScheduleDetail>();
        }
    }
}
