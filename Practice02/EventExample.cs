using System;

namespace Events
{
    public class EventExample
    {
        // Delegate definition         
         public delegate string Del(string str1, string str2);

        // Event declaration
        public event Del Myevent;

        public EventExample()
        {
            this.Myevent += Helper;
        }

        private string Helper(string str1, string str2)
        {
            return "Hello " + str1 + " " + str2;
        }

        // Method to raise the event
        public void RaiseEvent(string a, string b)
        {
            if (Myevent != null)
            {
                string result = Myevent(a, b);
                Console.WriteLine("Event result: " + result);
            }
        }
    }

  
}