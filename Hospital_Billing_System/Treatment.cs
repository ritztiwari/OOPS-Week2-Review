using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Billing_System
{
    public class Treatment : Patient
    {
        private int treatmentCost;
        public int TreatmentCost
        {
            get { return treatmentCost; }
            set
            {
                if (value < 1000)
                {
                    throw new Exception("Treatment cost should be greater than 1000");
                }
                treatmentCost = value;
            }
        }
        public Treatment(string name, int patientId, double emergencyCharges, int treatmentCost)
            : base(name, patientId, emergencyCharges)
        {
            TreatmentCost = treatmentCost;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Patient Name: {Name}");
            Console.WriteLine($"Patient Id: {PatientId}");
            Console.WriteLine($"Total bill Amount: {base.CalculateBill() + treatmentCost}");
        }
    }
}
