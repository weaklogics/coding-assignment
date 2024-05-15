using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal class CourseRepository:IcourseRepository
    {
        Course course;
        Student student;

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public CourseRepository()
        {
            sqlConnection = new SqlConnection("Server = localhost; Database = Car_rental; User Id = sa; Password = reallyStrongPwd123; TrustServerCertificate = True");
            cmd = new SqlCommand();
        }

        public int AssignTeacher(Teacher teacher, Course course)
        {
            //clearing paramateres
            //cmd.Parameters.Clear()

            cmd.CommandText = "UPDATE Courses SET teacher_id = @tid WHERE course_id = @cid )";
            cmd.Parameters.AddWithValue("@teacher_id", teacher.teacherId);
            cmd.Parameters.AddWithValue("@cid", course.courseId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int returnLeaseStatus = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return returnLeaseStatus;
        }

        public Courses DisplayCourseInfo(Courses course)
        {

            cmd.CommandText = "SELECT course_id,course_name,course_code,concact(t.first_name + ' ' , t.last_name) as Instructor_Name FROM Courses c JOIN Teachers t ON c.course_id = t.course_id WHERE course_id = @cid ";
            cmd.Parameters.AddWithValue("@cid", course.courseId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                course.courseId = (int)reader["course_id"];
                course.courseCode = (string)reader["course_code"]; //to be added in db
                course.courseName = (string)reader["course_name"];
                course.instructorName = (string)reader["Instructor_Name"];
            }
            sqlConnection.Close();
            return course;
        }

        public List<Student> GetEnrollments(Courses course)
        {
            List<Student> students = new List<Student>();
            cmd.CommandText = "select concat(s.first_name + ' ' , s.last_name) as Students from Students s JOIN Enrollment e ON e.student_id = s.student_id WHERE course_id = @cid";
            cmd.Parameters.AddWithValue("@cid", course.courseId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                student.studentId = (int)reader["student_id"];
                student.FirstName = (string)reader["first_name"];
                student.LastName = (string)reader["last_name"];
                student.DateOfBirth = (DateTime)reader["date_of_birth"]; 
                student.Email = (string)reader["email"];
                student.PhoneNumber = (string)reader["phone_number"];
                students.Add(student);
            }
            sqlConnection.Close();
            return students;
        }

        public string GetTeacher(Courses course)
        {
            cmd.CommandText = "select concat(t.first_name + ' ' , t.last_name) as Teacher_Name from Teacher t JOIN Courses c ON c.teacher_id = t.teacher_id WHERE course_id = @cid";
            cmd.Parameters.AddWithValue("@cid", course.courseId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string TeacherName = (string)reader["Teacher_Name"];
            sqlConnection.Close();
            return TeacherName;
        }
    }

}
