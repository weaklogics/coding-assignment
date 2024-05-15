using Assignment.Exceptions;
using Assignment.Model;
using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services
{
   
    
        public class StudentRepositoryService
        {
        public class StudentRepositoryService
        {
            readonly iStudentRepository _studentrepo;


            public StudentRepositoryService()
            {
                _studentrepo = new StudentRepository();
            }

            public void AddStudent()
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Student Addition Department~");
                Console.WriteLine("~Please Fill below details of the Student~");
                Console.WriteLine(" First Name");
                student.FirstName = Console.ReadLine();
                Console.WriteLine(" Last Name");
                student.LastName = Console.ReadLine();
                Console.WriteLine(" Date of Birth (format: dd-MM-yyyy)");
                student.dob = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine(" Email ");
                student.Email = Console.ReadLine();
                if (!student.Email.Contains("@"))
                {
                    throw new InvalidStudentDataException("Invalid email format. Please use the format: abc@example.com");
                }

                Console.WriteLine(" Phone Number ");
                student.PhoneNumber = (Console.ReadLine());
                if (student.PhoneNumber.Length > 10)
                {
                    throw new InvalidStudentDataException("Phone Number Contains More Than 10 Numbers");
                }


                _studentrepo.AddStudent(student);
            }


            public void DeleteStudent()
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Student Deletion Department~");
                Console.WriteLine("~Please Fill below details of the Student~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                _studentrepo.DeleteStudent(student);

            }


            public void EnrollInCourse()
            {
                Student student = new Student();
                Courses course = new Courses();
                Console.WriteLine("~Welcome To Course Enrollment Department~");
                Console.WriteLine("~Please Fill below details of the Student~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Course Id");
                course.CourseId = Convert.ToInt32(Console.ReadLine());

                _studentrepo.EnrollInCourse(student, course);

            }



            public void MakePayment()
            {
                Student student = new Student();
                Payment pay = new Payment();
                Console.WriteLine("~Welcome To Payments Department~");
                Console.WriteLine("~Please Fill below details ~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Amount");
                pay.Amount = Convert.ToInt32(Console.ReadLine());

                _studentrepo.MakePayment(student, pay);

            }

            public void DisplayStudentInfo()
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Student Information Department~");
                Console.WriteLine("~Please Fill below details of the Student~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(_studentrepo.DisplayStudentInfo(student));

            }

            public void UpdateStudentInfo()
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Student Updatation Department~");
                Console.WriteLine("~Please Fill below details of the Student~");
                Console.WriteLine(" Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" First Name");
                student.firstName = Console.ReadLine();
                Console.WriteLine(" Last Name");
                student.lastName = Console.ReadLine();
                Console.WriteLine(" Date of Birth (format: dd-MM-yyyy)");
                student.dob = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine(" Email ");
                student.Email = (Console.ReadLine());
                if (!student.Email.Contains("@"))
                {
                    throw new InvalidStudentDataException("Invalid email format. Please use the format: abc@example.com");
                }

                Console.WriteLine(" Phone Number ");
                student.PhoneNumber = (Console.ReadLine());
                if (student.PhoneNumber.Length > 10)
                {
                    throw new InvalidStudentDataException("Phone Number Contains More Than 10 Numbers");
                }


                _studentrepo.UpdateStudentInfo(student);
            }

            public void GetPaymentHistory() //working
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Payments Department~");
                Console.WriteLine("~Please Fill below details ~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());
                List<Payment> stu = _studentrepo.GetPaymentHistory(student); ;
                foreach (Payment item in stu)
                {
                    Console.WriteLine(item);
                }
            }


            public void GetEnrolledCourses()
            {
                Student student = new Student();
                Console.WriteLine("~Welcome To Enrollments Department~");
                Console.WriteLine("~Please Fill below details ~");
                Console.WriteLine("Student Id");
                student.studentId = Convert.ToInt32(Console.ReadLine());

                List<Enrollment> stu = _studentrepo.GetEnrolledCourses(student);
                foreach (Enrollment item in stu)
                {
                    Console.WriteLine(item);
                }
            }


        }

    }

