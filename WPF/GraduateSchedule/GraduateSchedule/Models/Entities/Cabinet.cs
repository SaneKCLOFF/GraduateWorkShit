using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Cabinet
    {
        public Cabinet()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public int Number { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
