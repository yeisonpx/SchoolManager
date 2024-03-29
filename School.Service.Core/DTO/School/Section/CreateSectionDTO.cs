﻿using System;
using School.Common.Enums;

namespace School.Service.Core.DTO.School.Section
{
    public class CreateSectionDTO
    {
        public Guid SchoolId { get; set; }
        public string Code { get; set; }
        public string MaxStudentsCapacity { get; set; }
        public SectionStatus Status { get; set; }
    }
}
