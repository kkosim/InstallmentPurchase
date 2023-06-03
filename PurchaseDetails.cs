using System;

namespace installmentPurchase
{
    class PurchaseDetails
    {
        public string productType {get; set;}
        public double summa{get; set;}
        public string phoneNumber{get; set;}
        public int durationMonths{get; set;}
        public PurchaseDetails()
        {
            System.Console.WriteLine("Object creation");
        }
        public PurchaseDetails(string productType, double summa, string phoneNumber, int durationMonths)
        {
            this.productType = productType;
            this.summa = summa;
            this.phoneNumber = phoneNumber;
            this.durationMonths = durationMonths;
        }
        
        public double Calculate()
        {
            double percent = 0;
            int term = 0;
            double totalPrice = summa;
            if (durationMonths >= 3)
            {
                switch(productType)
                {
                    case "Smartphone":
                        percent = 0.03;
                        if (durationMonths % 9 == 0)
                        {
                            term = durationMonths / 9;
                        } 
                        else
                        {
                            term = durationMonths / 9 + 1;
                        }
                        break;
                    case "Computer":
                        percent = 0.04;
                        if (durationMonths % 12 == 0)
                        {
                            term = durationMonths / 12;
                        } 
                        else
                        {
                            term = durationMonths / 12 + 1;
                        }
                        break;
                    case "TV":
                        percent = 0.05;
                        if (durationMonths % 18 == 0)
                        {
                            term = durationMonths / 18;
                        } 
                        else
                        {
                            term = durationMonths / 18 + 1;
                        }
                        break;
                }
    
                totalPrice += totalPrice * term * percent;
            }
            else
            {
                System.Console.WriteLine("Not valid installment duration!");
                return 0;
            }
            return totalPrice;
        }
    }
}