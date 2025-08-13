using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocumentsManagerRU.ImpersonationClass
{
    public class UserCredentials
    {
        public UserCredentials(string domain, string login, string password)
        {
            _domain = domain;
            _login = login;
            _password = password;
        }

        /// <summary>
        /// Domena, login, hasło
        /// </summary>
        /// <returns></returns>
        public static UserCredentials GetScansOperator()
        {
            UserCredentials user = GlobalSettings.ScanOperator;
            return user;
        }

        private string _domain;
        private string _login;
        private string _password;
        public string Domain 
        {
            get{ return _domain; }
        }
        public string Login { 
            get{ return _login; }
        }
        public string Password
        {
            get { return _password; }
        }
    }
}
