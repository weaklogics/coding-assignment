using Assignment.Model;
using Assignment.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal class StudentRepository : IstudentRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public StudentRepository()
        {
            sqlConnection = new SqlConnection(DbConUtil.GetConnectionString());
            cmd = new SqlCommand();

        }
       public List<Student> DisplayStudentsInfo()
         {
             List<Student> students = new List<Student>();
             using (SqlConnection sqlConnection = new SqlConnection(DbConUtil.GetConnectionString()))
             {
                 cmd.CommandText = "select * from students";
                 cmd.Connection = sqlConnection;
                 sqlConnection.Open();
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     Student student = new Student();
                     student.StudentId = (int)reader["Student_Id"];
                     student.FirstName = (string)reader["First_Name"];
                     student.LastName = (string)reader["Last_Name"];
                     student.DateOfBirth = (DateTime)reader["date_of_birth"];
                     student.PhoneNumber = (string)reader["phone_number"];

                     student.Email = (string)reader["email"];

                     students.Add(student);
                 }
                 return students;
             }
         }
   

        public List<Enrollment> GetEnrolledCourses(Student student) 
        {
            List<Enrollment> enroll = new List<Enrollment>();
            cmd.CommandText = "SELECT * FROM Enrollments where student_id = @student_id ";
            cmd.Parameters.AddWithValue("@student_id", student.studentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Enrollment enrol = new Enrollment();
                enrol.EnrollmentId = (int)reader["enrollment_id"];
                enrol.CourseId = (int)reader["course_id"];
                enrol.EnrollmentDate = (string)reader["enrollment_date"];
                enroll.Add(enrol);
            }
            sqlConnection.Close();
            return enroll;
        }

    
    }
}