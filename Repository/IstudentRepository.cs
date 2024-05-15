using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal interface IstudentRepository
    {
        List<Student> DisplayStudentsInfo();
        List<Enrollment> GetEnrolledCourses(Student student);

        int AddStudent(Student student);

        int DeleteStudent(Student student);

        int EnrollInCourse(Student student, Courses course);

        int UpdateStudentInfo(Student student);

        int MakePayment(Student student, Payment payment);

        Student DisplayStudentInfo(Student student);

      

        List<Payment> GetPaymentHistory(Student student);
    }
}
