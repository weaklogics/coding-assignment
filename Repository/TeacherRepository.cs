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
    internal class TeacherRepository:IteacherRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        Teacher teacher;


        public TeacherRepository()
        {
            sqlConnection = new SqlConnection("Server=localhost;Database=Car_rental;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True");
            sqlConnection = new SqlConnection(DbConUtil.GetConnectionString());
            cmd = new SqlCommand();
        }


        public void UpdateTeacherInfo()
        {


        }

        public Teacher DisplayTeacherInfo()
        {
            teacher = new Teacher();
            cmd.CommandText = "select * from Teacher where teacher_id = @teacher_id";
            cmd.Parameters.AddWithValue("@teacher_id", teacher.TeacherId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                teacher.TeacherId = (int)(reader["taecher_id"]);
                teacher.FirstName = (string)reader["first_name"];
                teacher.LastName = (string)reader["last_name"];
                teacher.Email = (string)reader["email"];
            }
            sqlConnection.Close();
            return teacher;

        }


        public List<Courses> GetAssignedCourses()
        {
          
            teacher = new Teacher();
            List<Courses> course = new List<Courses>();
            cmd.CommandText = "select * from Course c JOIN Teacher t ON c.teacher_id = t.teacher_id WHERE teacher_id = @tid";
            cmd.Parameters.AddWithValue("@tid", teacher.TeacherId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Courses course1 = new Courses();
                course1.courseId = (int)reader["course_id"];
                course1.courseCode = (string)reader["course_code"]; 
                course1.courseName = (string)reader["course_name"];
                course.Add(course1);

            }
            sqlConnection.Close();
            return course;


        }


    }
}
}
