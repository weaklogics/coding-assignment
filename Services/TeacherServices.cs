using Assignment.Model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services
{

    public class TeacherServices
    {
        readonly iTeacherRepository _teacherrepository;

        public TeacherServices()
        {
            _teacherrepository = new TeacherRepository();
        }

        public void UpdateTeacherInfo()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("~Teacher Detail Updation Menu~");
            Console.WriteLine("Teacher Id");
            teacher.TeacherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Name");
            teacher.FirstName = (Console.ReadLine());
            Console.WriteLine("Last Name");
            teacher.LastName = (Console.ReadLine());
            Console.WriteLine(" Email");
            teacher.Email = (Console.ReadLine());
            Console.WriteLine(" Expertise");

        }


        public void DisplayTeacherInfo() //running format needs to be changed
        {
            Console.WriteLine("~Welcome To Teacher Management~");
            Teacher teach1 = new Teacher();
            Console.WriteLine("Enter Teacher Id");
            teach1.TeacherId = Convert.ToInt32(Console.ReadLine());

            // Call service method to retrieve teachers

            Console.WriteLine(_teacherrepository.DisplayTeacherInfo(teach1));

        }



        public void GetAssignedCourses()
        {
            Console.WriteLine("~Welcome To Teacher Course Management~");
            Teacher teach1 = new Teacher();
            Console.WriteLine("Enter Teacher Id");
            teach1.TeacherId = Convert.ToInt32(Console.ReadLine());

            List<Courses> courses = _teacherrepository.GetAssignedCourses(teach1);

            if (courses.Count > 0)
            {
                Console.WriteLine("~ List of Courses for Teacher ID: " + teach1.TeacherId + " ~");
                foreach (Courses course in courses)
                {
                    Console.WriteLine($"{course.CourseId} - {course.CourseName} ({course.CourseCode})"); //teacher id to be added left
                }
            }
            else
            {
                Console.WriteLine("No courses found for teacher ID: " + teach1.teacherId);
            }
        }

    }
}
