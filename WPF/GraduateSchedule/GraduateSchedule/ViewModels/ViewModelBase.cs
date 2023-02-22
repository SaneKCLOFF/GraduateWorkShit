using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateSchedule.ViewModels
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        protected bool Set<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field,value)) return false;
            field = value;
            OnPropertyChange(propertyName);
            return true;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
