using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    internal class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string EnrollmentDate { get; set; }
        public Enrollment() { }
        public Enrollment(int enrollmentId, int studentId, int courseId, string enrollmentDate)
        {
            EnrollmentId = enrollmentId;
            StudentId = studentId;
            CourseId = courseId;
            EnrollmentDate = enrollmentDate;
        }
        public override string ToString()
        {
            return $"Enrollment ID: {EnrollmentId}, Course ID: {CourseId}, Enrollment Date: {EnrollmentDate}";
        }
    }
}
