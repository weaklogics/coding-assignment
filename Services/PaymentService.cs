using Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Services
{
    internal class PaymentService
    {
        readonly iPaymentRepository _paymentrepository;

        public PaymentRepositoryService()
        {
            _paymentrepository = new PaymentRepository();
        }

        public void GetStudent() //running format left
        {
            Console.WriteLine("~Welcome To Payment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());
            Console.WriteLine(_paymentrepository.GetStudent(paymentId));

        }


        public void GetPaymentAmount() //running
        {

            Console.WriteLine("~Welcome To Payment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());

            // Retrieve payment amount (optional)
            decimal paymentAmount = _paymentrepository.GetPaymentAmount(paymentId);
            if (paymentAmount > 0)
            {
                Console.WriteLine("Payment amount for ID " + paymentId + ": " + paymentAmount);
            }
        }

        public void GetPaymentDate() //running
        {
            Console.WriteLine("~Welcome To Payment Department~");
            Console.WriteLine("~Please Fill below details ~");
            Console.WriteLine("Payment Id");
            int paymentId = int.Parse(Console.ReadLine());

            decimal paymentAmount = _paymentrepository.GetPaymentAmount(paymentId);
            DateTime paymentDate = _paymentrepository.GetPaymentDate(paymentId);
            if (paymentDate != null) // Check for null value
            {
                Console.WriteLine("Payment date for ID " + paymentId + ": " + "Payment Amount " + ": " + paymentAmount + "Payment Amount " + ": " + paymentDate.ToString("yyyy-MM-dd"));
            }


        }
    }

}
}
