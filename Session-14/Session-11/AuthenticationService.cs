using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11

{
    public class AuthenticationService
    {
        private string _username;
        private string _password;
        public LoginForm LoginForm { get; set; }

        public string Username { get => _username; }
        public AuthenticationService(LoginForm logiiForm)
        {
            LoginForm = logiiForm;
            _username = "admin";
            _password = "admin12345";
        }

        public bool ValidateUser(string username, string password) => username == _username && password == _password;       
    }

}
