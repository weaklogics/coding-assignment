using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository
{
    internal interface IpaymentRepository
    {
        Student GetStudent(int paymentId);
        decimal GetPaymentAmount(int paymentId);
        DateTime GetPaymentDate(int paymentId);
    }
}
