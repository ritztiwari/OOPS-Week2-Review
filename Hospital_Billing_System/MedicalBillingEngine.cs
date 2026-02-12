namespace Hospital_Billing_System
{
    public class MedicalBillingEngine : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Medical billing resources released");
        }
    }
}
