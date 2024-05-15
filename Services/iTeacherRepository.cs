using Assignment.Model;
using Assignment.Repository;

namespace Assignment.Services
{
    internal class iTeacherRepository
    {
        internal bool DisplayTeacherInfo(Teacher teach1)
        {
            throw new NotImplementedException();
        }

        internal List<Courses> GetAssignedCourses(Teacher teach1)
        {
            throw new NotImplementedException();
        }

        public static implicit operator iTeacherRepository(TeacherRepository v)
        {
            throw new NotImplementedException();
        }
    }
}