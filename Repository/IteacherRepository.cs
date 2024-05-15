using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal class IteacherRepository
    {
        public void UpdateTeacherInfo();
        public Teacher DisplayTeacherInfo();
        public List<Course> GetAssignedCourses();
    }
}
