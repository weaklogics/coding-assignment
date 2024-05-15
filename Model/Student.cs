using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    internal class Student
    {
        internal int studentId;

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

  

        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public Student() { }
        public Student(int studentId, string firstName, DateTime dateofbirth,string lastName, string email, string phoneNumber)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            dateofbirth =dateofbirth;
            PhoneNumber = phoneNumber;  
            Email = email;
           

        }
        public override string ToString()
        {
            return $"Student ID: {StudentId}, Name: {FirstName}  {LastName}, Email: {Email} , PhoneNumber:{PhoneNumber},Date:{DateOfBirth}";
        }
    }
}
