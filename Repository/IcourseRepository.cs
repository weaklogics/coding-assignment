using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal interface IcourseRepository
    {
        int AssignTeacher(Teacher teacher, Courses course);
        bool UpdateCourseInfo(int CourseCode, string CourseName, string instructor);
        Courses DisplayCourseInfo(Courses course);
        List<Student> GetEnrollments(Courses course);
        string GetTeacher(Courses course);
    }
}
