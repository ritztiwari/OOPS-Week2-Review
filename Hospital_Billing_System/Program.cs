using System;
namespace Hospital_Billing_System
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hospital Billing System");
            Treatment treatment = new Treatment("Sita",509,2000,18000);
            treatment.DisplayDetails();
            using (MedicalBillingEngine engine = new MedicalBillingEngine())
            {
                
            }
        }
    }
}