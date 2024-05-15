using Assignment.Model;
using Assignment.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal class EnrollmentRepository:Ienrollment
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public EnrollmentRepository()
        {
            sqlConnection = new SqlConnection(DbConUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        Student s1;
        public string GetStudent(Enrollment enroll)
        {
            cmd.CommandText = "select concat (s.first_name + ' ' , s.last_name) as Student_Name from Student s JOIN Enrollments e ON s.student_id = e.student_id WHERE enrollment_id = @eid";
            cmd.Parameters.AddWithValue("@eid", enroll.EnrollmentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string StudentName = (string)reader["Student_Name"];
            sqlConnection.Close();
            return StudentName;
        }

        public string GetCourse(Enrollment enroll)
        {
            cmd.CommandText = "select course_name from Courses c JOIN Enrollments e ON c.course_id = e.course_id WHERE enrollment_id = @eid";
            cmd.Parameters.AddWithValue("@eid", enroll.EnrollmentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string CName = (string)reader["course_name"];
            sqlConnection.Close();
            return CName;
        }


    }

}

