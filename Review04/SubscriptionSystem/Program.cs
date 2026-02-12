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
    public class Program
    {
        public static void Main(string[] args)
        {try{
            Console.WriteLine("Email Subscription System");
            ManageSubscription mng=new ManageSubscription();

            mng.Events.OnUserSubscribed += (source, email) =>
            {
                Console.WriteLine($"Event: User subscribed with email {email}");
            };
            Console.WriteLine("Enter no. of emails to subscribe:");
            int n=int.Parse(Console.ReadLine());
         var subsCount=mng.SubscriptionCount();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                try
                {
                    mng.CreateUser(email);
                    Console.WriteLine($"Subscription successful for email: {email}");
                    Console.WriteLine($"Total subscriptions: {subsCount()}");
                }
                catch (InvalidEmailException ex)
                {
                    Console.WriteLine($"Subscription failed: {ex.Message}");
                }
                
            }
      
        }catch(Exception ex){
            Console.WriteLine(ex.Message);
            }


        }
    }
}