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
    public class User
    {
        public string Email { get; set; }
        public User(string email)
        {
            Email = email;
        }

    }
}