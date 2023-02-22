using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Class
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int GroupId { get; set; }
        public int CabinetId { get; set; }
        public int TimetableId { get; set; }
        public int ClassTypeId { get; set; }

        public virtual Cabinet Cabinet { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual Timetable Timetable { get; set; } = null!;
    }
}
