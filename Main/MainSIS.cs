using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Main
{
    internal class MainSIS
    {
        internal class Menu
        {
            readonly IstudentRepository _studentrepo;
            readonly IenrollmentRepository _enrollmentrepo;
            readonly IpaymentRepository _paymentrepo;
            readonly IteacherRepository _eacherrepo;
            readonly IcourseRepository _courserepo;


            public Menu(IstudentRepository studentrepo, IenrollmentRepository enrollmentrepo, IpaymentRepository paymentrepo,
                IteacherRepository teacherrepo, IcourseRepository courserepo)
            {
                _studentrepo = studentrepo;

                _enrollmentrepo = enrollmentrepo;
                _paymentrepo = paymentrepo;
                _eacherrepo = teacherrepo;
                _courserepo = courserepo;


            }
            public void run()
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("*******************WELCOME TO STUDENT INFORMATION SYSTEM*******************");
                    Console.WriteLine("PRESS 1 FOR STUDENT SERVICES");
                    Console.WriteLine("PRESS 2 FOR COURSES SERVICES");
                    Console.WriteLine("PRESS 3 FOR TEACHER  SERVICES");
                    Console.WriteLine("PRESS 4 FOR ENROLLMENT SERVICES");
                    Console.WriteLine("PRESS 5 FOR PAYMENT SERVICES");
                    Console.WriteLine("PRESS 0 TO EXIT");
                    Console.WriteLine("ENTER YOUR CHOICE");
                    int useriput = int.Parse(Console.ReadLine());

                    switch (useriput)
                    {
                        case 1:
                            ManageStudents();
                            break;
                        case 2:
                            ManageCourses();
                            break;

                        case 3:
                            ManageTeacher();
                            break;

                        case 4:
                            ManageEnrollment();
                            break;
                        case 5:
                            ManagePayment();
                            break;
                        case 0:
                            exit = true;
                            Console.WriteLine("exited");
                            break;
                        default:
                            Console.WriteLine("ENTER CORRECT INPUT ");
                            break;
                    }




                }
            }
            private void ManageStudents()
            {
                Console.WriteLine("**********STUDENT SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO ENROLL IN COURSE");
                Console.WriteLine("PRESS 2 TO UPDATE STUDENT INFO");

                Console.WriteLine("PRESS 3 TO MAKE PAYMENT");

                Console.WriteLine("PRESS 4 TO DISPLAY STUDENT INFO");
                Console.WriteLine("PRESS 5 TO GET ENROLLED COURSES");
                Console.WriteLine("PRESS 6 TO GET PAYMENT HISTORY ");

                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.EnrollInCourse();
                        break;
                    case 2:
                        _studentrepo.UpdateStudentInfo();
                        break;
                    case 3:
                        _studentrepo.MakePayment();
                        break;
                    case 4:
                        _studentrepo.DisplayStudentInfo();
                        break;
                    case 5:
                        _studentrepo.GetEnrolledCourses();
                        break;
                    case 6:
                        _studentrepo.GetPaymentHistory();
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }
            }

            private void ManageCourses()
            {
                Console.WriteLine("**********COURSES SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO ASSIGN TEACHER");
                Console.WriteLine("PRESS 2 TO UPDATE COURSE INFO");

                Console.WriteLine("PRESS 3 DISPLAY COURSE INFO");

                Console.WriteLine("PRESS 4 TO GET ENROLLMENTS");

                Console.WriteLine("PRESS 5 TO GET TEACHER DETAILS ");

                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.AssignTeacher();
                        break;
                    case 2:
                        _studentrepo.DisplayCourseInfo();
                        break;
                    case 3:
                        _studentrepo.GetEnrollments();
                        break;
                    case 4:
                        _studentrepo.GetTeacher();
                        break;
                    case 5:
                        _studentrepo.();
                        break;

                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManageTeacher()
            {
                Console.WriteLine("**********TEACHER SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO UPDATE TEACHER INFO");


                Console.WriteLine("PRESS 2  TO DISPLAY TEACHER INFO");

                Console.WriteLine("PRESS 3 TO GET ASSIGNED COURSES");



                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.();
                        break;
                    case 2:
                        _studentrepo.();
                        break;
                    case 3:
                        _studentrepo.();
                        break;


                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManageEnrollment()
            {
                Console.WriteLine("**********ENROLLMENT SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO GET STUDENT ASSOCIATED WITH ENROLLMENT");


                Console.WriteLine("PRESS 2  TO GET ENROLLED COURSE");




                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.GetStudent();
                        break;
                    case 2:
                        _studentrepo.GetCourse();
                        break;



                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }



            }
            private void ManagePayment()
            {
                Console.WriteLine("**********PAYMENT SERVICE MENU**********");
                Console.WriteLine("PRESS 1 TO GET STUDENT ASSOCIATED WITH PAYMENT");


                Console.WriteLine("PRESS 2  TO GET PAYMENT AMOUNT");
                Console.WriteLine("PRESS 3 TO GET PAYMENT DATE");




                int userinput = int.Parse(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        _studentrepo.GetStudent();
                        break;
                    case 2:
                        _studentrepo.GetCourse();
                        break;
                    case 3: ();



                    default:
                        Console.WriteLine("ENTER CORRECT DETAILS ");
                        break;
                }



            }


        }
    }
}
