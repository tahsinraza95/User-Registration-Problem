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
        public static string FirstName = @"^[A-Z]{1}[a-z]{2,}$";

    }
    public class RegistrationForm
    {
        public bool Firstname(string userName)
        {
            Regex name = new Regex(Pattern.FirstName);
            return name.IsMatch(userName);
        }
    }
}