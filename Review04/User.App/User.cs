/*
create user with email,password and validate it by regex
*/
namespace User.App
{
    public class User
    {
        public string Name{get;set;}
        public string Email{ get; set;}

       public string Password{ get; set;}   
public User(string email, string password,String name)
        {
            Name=name;
            Email=email;
            Password=password;
        }


}

}