using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? TeacherId { get; set; }

        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
