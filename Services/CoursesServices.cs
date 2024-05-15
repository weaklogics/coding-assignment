using Assignment.Model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services
{
    internal class CoursesServices
    {
        readonly iCourseRepository _courserepo;

        public CourseRepositoryService()
        {
            _courserepo = new CourseRepository();
        }



        public void AssignTeacher()
        {

            Teacher teacher = new Teacher();
            Courses course = new Courses();
            Console.WriteLine("~Welcome To Teacher Assignment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Teacher Id");
            teacher.TeacherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Course Id");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            _courserepo.AssignTeacher(teacher, course);

        }

        public void DisplayCourseInfo()
        {
            Courses course = new Courses();
            Console.WriteLine("~Welcome To Course Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Course Id");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_courserepo.DisplayCourseInfo(course));
        }

        public void GetEnrollments()
        {
            Courses course = new Courses();
            Console.WriteLine("~Welcome To Course Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Course Id");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_courserepo.GetEnrollments(course));
        }


        public void GetTeacher()
        {
            Courses course = new Courses();
            Console.WriteLine("~Welcome To Course Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Course Id");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(_courserepo.GetTeacher(course));

        }
    }
}
