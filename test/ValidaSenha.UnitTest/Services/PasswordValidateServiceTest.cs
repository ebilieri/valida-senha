using FluentAssertions;
using ValidaSenhaApi.Services;
using Xunit;

namespace ValidaSenha.UnitTest.Services
{
    public class PasswordValidateServiceTest 
    {
        private readonly IPasswordValidateService _passwordValidate;

        public PasswordValidateServiceTest()
        {
            _passwordValidate = new PasswordValidateService();
        }

        [Theory]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData("         ", false)]
        [InlineData("aa", false)]
        [InlineData("ab", false)]
        [InlineData("AAAbbbCc", false)]
        [InlineData("AbTp9!foo", false)]
        [InlineData("AbTp9!foA", false)]
        [InlineData("AbTp9 fok", false)]
        [InlineData("AbTp9!fok", true)]
        [InlineData("ABTP9!fok", true)]
        [InlineData("!@#%zxc12354", false)]
        [InlineData("!@#%zXc12354", true)]
        public void PasswordValidateService_Validate_Sucesso(string password, bool expected)
        {
            var retorno = _passwordValidate.Validate(password);

            retorno.Should().Be(expected);
        }

    }
}
