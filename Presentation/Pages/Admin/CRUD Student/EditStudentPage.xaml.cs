using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Exam.Presentation.Pages.Admin.CRUD_Student
{
    public partial class EditStudentPage : Window
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=WIN-0I7PB3TGH35\SQLEXPRESS;Initial Catalog=University;Integrated Security=True;Encrypt=False";

        public EditStudentPage()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            InitializeComponent();
        }

        private void ClearDataGrid()
        {
            DG_Students.ItemsSource = null;
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            

            txtName.Text = "";
            txtPhoto.Text = "";
            txtId.Text = "";
        }

        private void ExitBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Presentation.Pages.Admin.AdminHomePage adminHomePage = new Presentation.Pages.Admin.AdminHomePage();
            adminHomePage.Show();
            this.Close();
        }
    }
}
