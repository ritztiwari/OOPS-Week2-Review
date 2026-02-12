/*
create user with email,password and validate it by regex with  exception handling, after that create login funtcionality
*/
using System;
using System.Text.RegularExpressions;
namespace User.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");

            Console.WriteLine("enter name:");
           string name= Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            string email=Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password=Console.ReadLine();
            try
            {
                if (!emailRegex.IsMatch(email))
                {
                    throw new Exception("Invalid email");

                }
            
                User user=new User(email,password,name);
                Console.WriteLine("User created successfully.");

            
          Console.WriteLine("------User Login---- \n");
                    
                    Console.WriteLine("enter email");
                   string loginEmail=Console.ReadLine();
                    Console.WriteLine("enter password");
                    string loginPassword=Console.ReadLine();

                    Login login=new Login();

                    bool check=login.LoginUser(loginEmail,loginPassword,user);

                    if (check)
                    {
                        Console.WriteLine("User login succesful");
                    }
                    else
                    {
                        Console.WriteLine("User login failed");
                    }


               

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}