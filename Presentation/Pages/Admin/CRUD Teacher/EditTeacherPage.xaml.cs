﻿using Exam.Domain.Entities;
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

namespace Exam.Presentation.Pages.Admin.CRUD_Teacher
{
    public partial class EditTeacherPage : Window
    {
        public EditTeacherPage()
        {
            InitializeComponent();
        }

        private void AddTeacher_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string photo = txtPhoto.Text;
            string id = txtId.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(photo) || string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            var newTeacher = new Domain.Entities.Teacher(name, photo, id);
            DataRepository.Instance.Teachers.Add(newTeacher);

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
