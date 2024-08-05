using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDeEmail
{

    public static class Email
    {
        public static bool ValidateEmailAddress(string email)
        {
            return email.Contains("@");

        }

        public static bool ValidateEmailAddresDot(string email)
        {
            string[] auxArray = email.Split('@');

            return (auxArray[1].Contains("."));
        }
    }




}



