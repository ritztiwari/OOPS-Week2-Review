using System;
using System.Text.RegularExpressions;
namespace SubscriptionSystem
{
    public class ValidateEmail
    {
        public static bool IsValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

    
            try
            {
                if (!emailRegex.IsMatch(email))
                {
                    throw new InvalidEmailException("Invalid email format.");

                }
                return true;
            
        }catch(InvalidEmailException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
    }
}
}

/*
Email Subscription & Notification System
(Events + Delegates + Regex + Closures)
Scenario
Users subscribe to email notifications.
Requirements
Validate email using Regex

Store subscribers in HashSet<string>

Raise OnUserSubscribed event

Use Closure to track:

Total subscriptions count

Reject duplicate subscriptions

Custom Exception:

InvalidEmailException

NUnit:

Duplicate email

Invalid email format

Event invocation count
*/