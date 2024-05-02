using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OCP.Program;

namespace OCP
{
    public interface IPayment
    {
        void PaymentProcess(double amount);
    }

    public class CreditCard : IPayment
    {
        public void PaymentProcess(double amount)
        {
            // Process credit card payment
        }
    }

    public class PayPal : IPayment
    {
        public void PaymentProcess(double amount)
        {

            //  Process PayPal payment
        }
    }

    public class BankTransfer : IPayment
    {
        public void PaymentProcess(double amount)
        {
            // Process  BankTransfer Payment
        }
    }
    public class Payment
    {
        private readonly IPayment _paymentProcessor;

        public Payment(IPayment paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ProcessPayment(double amount)
        {
            _paymentProcessor.PaymentProcess(amount);
        }
    }
}
