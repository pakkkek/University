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

namespace Exam.Domain.DB_Entity
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }

        public Admin(int adminID, string adminName)
        {
            AdminID = adminID;
            AdminName = adminName;
        }
    }

    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }

        public Teacher(int teacherID, string teacherName)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }
    }

    public class Schedule
    {
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleType { get; set; }
        public DateTime IssueDate { get; set; }

        public Schedule(int scheduleID, string scheduleName, string scheduleType, DateTime issueDate)
        {
            ScheduleID = scheduleID;
            ScheduleName = scheduleName;
            ScheduleType = scheduleType;
            IssueDate = issueDate;
        }
    }

    public class DatabaseManager
    {
        public string ConnectionString { get; set; }

        public SqlConnection sqlConnection { get; set; }

        public DatabaseManager(string connectionString)
        {
            ConnectionString = connectionString;
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public async Task<bool> OpenConnection()
        {
            try
            {
                await sqlConnection.OpenAsync();
                return true;
            }
            catch (SqlException sql_ev)
            {
                throw new Exception(sql_ev.Message);
            }
        }

        public async Task<bool> CloseConnection()
        {
            try
            {
                await sqlConnection.CloseAsync();
                return true;
            }
            catch (SqlException sql_ev)
            {
                throw new Exception(sql_ev.Message);
            }
        }

        public async Task ExecuteNonQuery(string query)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                await OpenConnection();
            }
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            await CloseConnection();
        }
    }
}
