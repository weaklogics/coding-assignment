using Assignment.Model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services
{
    internal class EnrollmentService
    {
        {
        readonly iEnrollmentRepository _enrollrepo;
        public EnrollmentRepositoryService()
        {
            _enrollrepo = new EnrollmentRepository();
        }

        public void GetStudent()
        {
            Enrollment enrollment = new Enrollment();
            Console.WriteLine("~Welcome To Enrollment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Enrollment Id");
            enrollment.enrollId = int.Parse(Console.ReadLine());
            Console.WriteLine(_enrollrepo.GetStudent(enrollment));
        }
        public void GetCourse()
        {
            Enrollment enrollment = new Enrollment();
            Console.WriteLine("~Welcome To Enrollment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Enrollment Id");
            enrollment.courseId = int.Parse(Console.ReadLine());
            Console.WriteLine($"Abc {_enrollrepo.GetCourse(enrollment)}");
        }

    }
}
}
