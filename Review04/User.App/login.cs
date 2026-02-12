// /*
// create user with email,password and validate it by regex
// */


namespace User.App
{
 public class Login
    {
        public bool LoginUser(string email, string password, User user)
        {
         
              if(user.Email==email && user.Password==password )
            {
                return true;
            }
            else
            {
                return false;
            }
                
          
         
        
    
    } 
}
}