using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class TeachersList
    {
        public List<Teacher> teachers = null;
        private Teacher selectedTeacher;
        public Teacher SelectedTeacher
        {
            get { return selectedTeacher; }
            set
            {
                selectedTeacher = value;
                OnPropertyChanged("Teacher");
            }
        }

        public TeachersList()
        {
            teachers = new List<Teacher>();
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers?.Add(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers?.Remove(teacher);
        }
        public void RemoveTeacher(int index)
        {
            teachers?.RemoveAt(index);
        }
        public void RemoveAllTeachers()
        {
            teachers?.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
