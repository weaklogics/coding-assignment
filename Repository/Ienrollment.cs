using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal interface Ienrollment
    {
        string GetStudent(Enrollment enroll);
        string GetCourse(Enrollment enroll);


    }
}
