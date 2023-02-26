using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_RegistrationByLambda
{
    public class Pattern
    {
        public static string FirstName = @"^[A-Z][a-z]{2,}$";
        public static string LastName = @"^[A-Z][a-z]{2,}$";
        public static string Email = @"^(?=[a-z])[a-z 0-9.!#+$%&_-]{3,}[@][a-z 0-9]{1,6}.(com|com.com|io|com.au|net|org)$";


    }
    public class RegistrationForm
    {
        public bool Firstname(string userName)
        {
            Regex name = new Regex(Pattern.FirstName);
            return name.IsMatch(userName);
        }

        public bool LastName(string userLastName)
        {
            Regex lastname = new Regex(Pattern.LastName);
            return lastname.IsMatch(userLastName);
        }
        public bool Email(string userEmail)
        {
            Regex email = new Regex(Pattern.Email);
            return email.IsMatch(userEmail);
        }


    }
}