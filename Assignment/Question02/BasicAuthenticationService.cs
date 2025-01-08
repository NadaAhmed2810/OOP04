using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question02
{
    internal class BasicAuthenticationService:IAuthenticationService
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Role {  get; set; }

        public bool AuthenticateUser(string Username, string Password)
        {
            if (this.Username == Username && this.Password == Password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string Username, string Role)
        {
            if (this.Username == Username && this.Role == Role)
            {
                return true;
            }
            return false;
        }
    }
}
