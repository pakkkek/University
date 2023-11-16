using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class StudentsList : INotifyPropertyChanged
    {
        public List<Student> students = null;
        private Student selectedStudent;
        public Student SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged("Student");
            }
        }

        public StudentsList()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students?.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students?.Remove(student);
        }
        public void RemoveStudent(int index)
        {
            students?.RemoveAt(index);
        }
        public void RemoveAllStudents()
        {
            students?.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
