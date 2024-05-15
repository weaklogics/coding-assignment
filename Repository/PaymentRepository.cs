using Assignment.Model;
using Assignment.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal class PaymentRepository:IpaymentRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;


        Student student;

        public PaymentRepository()
        {
            //sqlConnection = new SqlConnection("Server=DESKTOP-2LFUD90;Database=SISDB;Trusted_Connection=True");
            sqlConnection = new SqlConnection(DbConUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public Student GetStudent(int paymentId)
        {
            student = new Student();
            cmd.CommandText = "SELECT s.student_id, s.first_name, s.last_name FROM Students s JOIN Payments p ON s.student_id = p.student_id WHERE p.payment_id = @pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                student.studentId = (int)reader["student_id"];
                student.FirstName = (string)reader["first_name"];
                student.LastName = (string)reader["last_name"];

            }
            sqlConnection.Close();
            return student;
        }

        public decimal GetPaymentAmount(int paymentId)
        {
            // Retrieve payment amount from the database
            cmd.CommandText = "SELECT amount FROM Payment WHERE payment_id = @pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            decimal amount = (decimal)cmd.ExecuteScalar();
            sqlConnection.Close();
            return amount;
        }


        public DateTime GetPaymentDate(int paymentId)
        {
            // Retrieve payment date from the database
            cmd.CommandText = "SELECT payment_date FROM Payment WHERE payment_id = @pid";
            cmd.Parameters.AddWithValue("@pid", paymentId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            DateTime paymentDate = (DateTime)cmd.ExecuteScalar();
            sqlConnection.Close();
            return paymentDate;
        }



    }
}
}
