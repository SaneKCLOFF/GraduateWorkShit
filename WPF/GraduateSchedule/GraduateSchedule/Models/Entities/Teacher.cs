using System;
using System.Collections.Generic;

namespace GraduateSchedule.Models.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;

        public virtual ICollection<Subject> Subjects { get; set; }

        #region Custom fields and properties
        public string FullName
        {
            get => $"{LastName} {FirstName[0]}. {MiddleName[0]}.";
        }
        #endregion
    }
}
