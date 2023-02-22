using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Group
    {
        public Group()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public int SpecialtyId { get; set; }
        public DateTime DateOfEnrollment { get; set; }

        public virtual Specialty Specialty { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}
