using System;

namespace PaymentApp
{
    abstract class Payment
    {
        private double Amount;
        public int PaymentId {get; set;}
        public DateOnly PaymentDate {get; set;}
        public double amount
        {
            get{return Amount;}

            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Amount cannot be negative");
                }
                else
                {
                    Amount = value;
                }
                
            }
        }
   
        public Payment(int paymentId, DateOnly paymentDate, double amount)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            this.amount = amount;
        }

        public void ShowPaymentDetails()
        {
            Console.WriteLine($"Payment ID: {PaymentId}");
            Console.WriteLine($"Payment Date: {PaymentDate}");
            Console.WriteLine($"Amount: {amount}");
        }

        public abstract void ProcessPayment();
        public abstract void ValidatePayment();
    }

    class UPIPayment : Payment
    {
        public string UPIId {get; set;}

        public UPIPayment(int paymentId, DateOnly paymentDate, double amount, string upiId) : base(paymentId, paymentDate, amount)
        {
            UPIId = upiId;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing UPI Payment of {amount} using UPI ID: {UPIId}");
        }

        public override void ValidatePayment()
        {
            if (string.IsNullOrEmpty(UPIId))
            {
                Console.WriteLine("Invalid UPI ID");
            }
            else
            {
                Console.WriteLine("UPI Payment validated successfully");
            }
        }
    }

    class CreditCardPayment : Payment
    {
        public string CardNumber {get; set;}
        public int CVV {get; set;}
        public DateOnly ExpiryDate {get; set;}

        public CreditCardPayment(int paymentId, DateOnly paymentDate, double amount, string cardNumber, int cvv, DateOnly expiryDate) : base(paymentId, paymentDate, amount)
        {
            CardNumber = cardNumber;
            CVV = cvv;
            ExpiryDate = expiryDate;
        }
        
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Credit Card Payment of {amount} using Card Number: {CardNumber}");
        }

        public override void ValidatePayment()
        {
            if (string.IsNullOrEmpty(CardNumber) || CVV <= 0 || ExpiryDate < DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("Invalid Credit Card details");
            }
            else
            {
                Console.WriteLine("Credit Card Payment validated successfully");
            }
        }         
    }

    class NetBankingPayment : Payment
    {
        public string BankName {get; set;}
        public string AccountNumber {get; set;}

        public NetBankingPayment(int paymentId, DateOnly paymentDate, double amount, string bankName, string accountNumber) : base(paymentId, paymentDate, amount)
        {
            BankName = bankName;
            AccountNumber = accountNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Net Banking Payment of {amount} using Bank: {BankName}, Account Number: {AccountNumber}");
        }

        public override void ValidatePayment()
        {
            if (string.IsNullOrEmpty(BankName) || string.IsNullOrEmpty(AccountNumber))
            {
                Console.WriteLine("Invalid Net Banking details");
            }
            else
            {
                Console.WriteLine("Net Banking Payment validated successfully");
            }
        }         
    }
}