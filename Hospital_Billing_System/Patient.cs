using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Billing_System
{
    public class Patient : Person
    {
        private int patientId;
        private double emergencyCharges;
        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        public double EmergencyCharges
        {
            get { return emergencyCharges; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Emergency charges cannot be negative.");
                }
                emergencyCharges = value;
            }
        }
        public Patient(string name, int patientId, double emergencyCharges) : base(name)
        {
            PatientId = patientId;
            EmergencyCharges = emergencyCharges;
        }
        public override double CalculateBill()
        {
            return EmergencyCharges;
        }
    }
}
