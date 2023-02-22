using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class ClassType
    {
        public ClassType()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}
