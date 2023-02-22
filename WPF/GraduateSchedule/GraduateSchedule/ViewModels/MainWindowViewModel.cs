using GraduateSchedule.Models;
using GraduateSchedule.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateSchedule.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Classes = new List<Class>(GetClasses());
        }

        #region Fields
        private List<Class> _classes;

        #endregion
        #region Propeties
        public List<Class> Classes
        {
            get => _classes;
            set => _classes = value; 
        }
        public DateTime dateTime { get; set; }

        #endregion

        #region Methods
        private List<Class> GetClasses()
        {
            using (ApplicationDBContext context = new())
            {
                return context
                    .Classes
                    .Include(c=>c.Cabinet)
                    .Include(ct=>ct.ClassType)
                    .Include(g=>g.Group)
                        .ThenInclude(sp=>sp.Specialty)
                    .Include(s=>s.Subject)
                        .ThenInclude(t=>t.Teacher)
                    .Include(t=>t.Timetable)
                    .ToList();
            }
        }
        #endregion
    } // Сделать аналдогию со страницами?
    // Вывод по 7 записей, или 6 не включая седьмой день
    // Как обозначать дни?
    // Нужно ли их обозначать?
    // Сделать кастомное поле и свойство которое будет возвращать дату вместе с названием дня недели?
}
