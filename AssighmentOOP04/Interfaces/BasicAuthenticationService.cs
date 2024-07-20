using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssighmentOOP04.Interfaces
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName {  get; set; }

        public string Password { get; set; }
        public void AuthenticateUser()
        {
            if (UserName == Password)
            {
                Console.WriteLine("User is Authonticated");
            }
            else
                Console.WriteLine("User is Not Authonticated");
        }

        public void AuthorizeUser()
        {
            if (this.UserName == UserName)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        
    }
}
