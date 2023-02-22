using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Timetable
    {
        public Timetable()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Time { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}
