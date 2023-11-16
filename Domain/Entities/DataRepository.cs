using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Entities
{
    public class DataRepository
    {
        private static DataRepository instance;

        public ObservableCollection<Student> Students { get; private set; }
        public ObservableCollection<Teacher> Teachers { get; private set; }

        private DataRepository()
        {
            Students = new ObservableCollection<Student>();
            Teachers = new ObservableCollection<Teacher>();
        }

        public static DataRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataRepository();
                }
                return instance;
            }
        }
    }
}
