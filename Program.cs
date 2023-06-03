using System;

namespace installmentPurchase
{
    class Program
    {
        static void Main()
        {
            PurchaseDetails purchase = new PurchaseDetails();

            Console.WriteLine("Product type: ");
            purchase.productType = Console.ReadLine();
            
            Console.WriteLine("Product worth: ");
            purchase.summa = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Your phone number: ");
            purchase.phoneNumber = Console.ReadLine();
            
            Console.WriteLine("Installment duration: ");
            purchase.durationMonths = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("We are kindly reminding you of your installment proccess");
            Console.WriteLine("Your current debt is {0}", purchase.Calculate());
            Console.WriteLine("How much you would like to pay now: ");
            double payment;
            double leftToPay = purchase.Calculate();
            while(((payment = Convert.ToDouble(Console.ReadLine())) != null) && (leftToPay > 0))
            {
                if(leftToPay < payment)
                {
                    System.Console.WriteLine("You have overpaid, We dont have return policy so thank you XD");
                    break;
                } else if (leftToPay > payment)
                {
                    leftToPay = leftToPay - payment;
                    Console.WriteLine("Dear Customer this message was sent to your current phone number: {0}.", purchase.phoneNumber);
                    Console.WriteLine("You have paid {0} somoni. {1} left to pay", payment, leftToPay);
                } else
                {
                    System.Console.WriteLine("Thank you for choosing our bank. You have fully paid off the debt");
                    break;
                }
            }
        }
    }
}