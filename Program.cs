using Assignment.Model;
using Assignment.Repository;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IstudentRepository studentRepository = new StudentRepository();
            List<Student> allStudents = studentRepository.DisplayStudentsInfo();
            foreach (Student item in allStudents)
            {
                Console.WriteLine(item);
            }
            Student student = new Student();
            

           List<Enrollment> enrollments = studentRepository.GetEnrolledCourses(student);
           foreach (Enrollment enrollment in enrollments)
            {
                Console.WriteLine(enrollment);
            }



        }
    }
}
