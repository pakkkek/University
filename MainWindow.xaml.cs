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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            if (username == "admin" && password == "admin")
            {
                errorTextBlock.Visibility = Visibility.Hidden;
                Presentation.Pages.Admin.AdminHomePage adminHomePage = new Presentation.Pages.Admin.AdminHomePage();
                adminHomePage.Show();
                this.Close();
            }
            if (username == "student" && password == "student")
            {
                errorTextBlock.Visibility = Visibility.Hidden;
                Presentation.Pages.Student.StudentHomePage studentHomePage = new Presentation.Pages.Student.StudentHomePage();
                studentHomePage.Show();
                this.Close();
            }
            if (username == "teacher" && password == "teacher")
            {
                errorTextBlock.Visibility = Visibility.Hidden;
                Presentation.Pages.Teacher.TeacherHomePage teacherHomePage = new Presentation.Pages.Teacher.TeacherHomePage();
                teacherHomePage.Show();
                this.Close();
            }
            else if (username.Length == 0 && password.Length == 0)
            {
                errorTextBlock.Text = "Error! Username and password is empty";
                errorTextBlock.Visibility = Visibility.Visible;
                usernameTextBox.Background = System.Windows.Media.Brushes.IndianRed;
                passwordBox.Background = System.Windows.Media.Brushes.IndianRed;
            }
            else if (username.Length == 0)
            {
                errorTextBlock.Text = "Error! Username is empty";
                errorTextBlock.Visibility = Visibility.Visible;
                usernameTextBox.Background = System.Windows.Media.Brushes.IndianRed;
                passwordBox.Background = System.Windows.Media.Brushes.White;
            }
            else if (password.Length == 0)
            {
                errorTextBlock.Text = "Error! Password is empty";
                errorTextBlock.Visibility = Visibility.Visible;
                usernameTextBox.Background = System.Windows.Media.Brushes.White;
                passwordBox.Background = System.Windows.Media.Brushes.IndianRed;
            }
            else if (username.Length < 5)
            {
                errorTextBlock.Text = "Error! Username need have 5 symbols";
                errorTextBlock.Visibility = Visibility.Visible;
                usernameTextBox.Background = System.Windows.Media.Brushes.IndianRed;
                passwordBox.Background = System.Windows.Media.Brushes.White;
            }
            else
            {
                errorTextBlock.Text = "Error! Uncorrect username or password";
                errorTextBlock.Visibility = Visibility.Visible;
                usernameTextBox.Background = System.Windows.Media.Brushes.IndianRed;
                passwordBox.Background = System.Windows.Media.Brushes.IndianRed;
            }
        }

        private void CancelButton_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
