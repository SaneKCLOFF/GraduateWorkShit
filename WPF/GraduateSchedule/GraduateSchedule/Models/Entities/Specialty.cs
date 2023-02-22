using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Specialty
    {
        public Specialty()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
