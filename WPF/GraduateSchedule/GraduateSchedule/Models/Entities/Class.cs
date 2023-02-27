using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime DateOfClass { get; set; }

        public virtual Cabinet Cabinet { get; set; } = null!;
        public virtual ClassType ClassType { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual Timetable Timetable { get; set; } = null!;

        #region Custom fields and properties
        [NotMapped]
        public string CorrectDateOfClass
        {
            get => $"{GetDayOfWeek()} - {DateOfClass.Date.ToString("d")}";
        }
        public string TitleNumber
        {
            get => $"{Subject.Title} - {Cabinet.Number}";
        }
        public string ClassTeacher
        {
            get => $"{Subject.Teacher.FullName}";
        }
        #endregion

        #region Methods
        private string GetDayOfWeek()
        {
            switch (DateOfClass.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Понедельник";
                case DayOfWeek.Tuesday:
                    return "Вторник";
                case DayOfWeek.Wednesday:
                    return "Среда";
                case DayOfWeek.Thursday:
                    return "Четверг";
                case DayOfWeek.Friday:
                    return "Пятница";
                case DayOfWeek.Saturday:
                    return "Суббота";
                default:
                    return "Воскресенье";
            }
        }
        #endregion
    }
}
