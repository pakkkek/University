using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam.Presentation.Pages.Admin
{
    public partial class AdminHomePage : Window
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void ExitBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ManageSchedule_Click(object sender, RoutedEventArgs e)
        {
            Presentation.Pages.Admin.CRUD_Schedule.EditSchedulePage adminEditSchedulePage = new Presentation.Pages.Admin.CRUD_Schedule.EditSchedulePage();
            adminEditSchedulePage.Show();
            this.Close();
        }

        private void ManageTeacher_Click(object sender, RoutedEventArgs e)
        {
            Presentation.Pages.Admin.CRUD_Teacher.EditTeacherPage adminEditTeacherPage = new Presentation.Pages.Admin.CRUD_Teacher.EditTeacherPage();
            adminEditTeacherPage.Show();
            this.Close();
        }

        private void ManageStudent_Click(object sender, RoutedEventArgs e)
        {
            Presentation.Pages.Admin.CRUD_Student.EditStudentPage adminEditStudentPage = new Presentation.Pages.Admin.CRUD_Student.EditStudentPage();
            adminEditStudentPage.Show();
            this.Close();
        }
    }
}
