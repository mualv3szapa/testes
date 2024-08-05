using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacaoDeEmail;

namespace ValidacaoUnitTest
{
    public class ValidacaoUnitTest
    {
        [Theory]
        [InlineData("murilo.zapiello@gmail.com")]
        [InlineData("zapiello@gmail.com")]

        public void ValidateIfTheEmailHaveAddress(string email)
        {
            Assert.True(Email.ValidateEmailAddress(email));
        }

        [Theory]
        [InlineData("murilo.zapiello@gmail.com")]
        [InlineData("zapiello@gmail.com")]
        public void ValidateIfTheEmailHaveADot(string email)
        {
            Assert.True(Email.ValidateEmailAddresDot(email));
        }
    }
}
