using System;
using System.Collections.Generic;

namespace School.Domain
{
    public class School: Entity 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Section> Sections { get; set; }

        public School()
        {
        }
    }
}
