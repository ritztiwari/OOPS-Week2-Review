/*Email Subscription & Notification System
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

Event invocation count*/
using System;
namespace SubscriptionSystem
{
    public class ManageSubscription
    {
        public HashSet<string> subscribers= new HashSet<string>();
        int count=0;
        RaiseEvent raiseEvent= new RaiseEvent();
        public RaiseEvent Events =>raiseEvent;

     public   Func<int> SubscriptionCount()
        {
            return ()=>count;
        }
       public void CreateUser(string email)
        {try{
            if (!ValidateEmail.IsValidEmail(email))
                throw new InvalidEmailException("Invalid email format.");

            if (subscribers.Contains(email))
                throw new InvalidEmailException("Duplicate email subscription not allowed.");

            subscribers.Add(email);
            count++;
            raiseEvent.Raise(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
      

    }
}