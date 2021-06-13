using MoreLinq;
using System.Linq;
using ValidaSenhaApi.Helpers;

namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// PasswordValidate
    /// </summary>
    public class PasswordValidate : Password
    {
        // Protected Methods

        /// <summary>
        /// Validar quantidade de caracteres
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool NimeOrMoreCharacters(string password)
        {
            return RegexHelpers.nineOrMoreCharacters.IsMatch(password);
        }

        /// <summary>
        /// Validar caracteres em branco
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool NotSpacesCharacters(string password)
        {
            //bool s  = RegexHelpers.notSpacesCharacters.IsMatch(password);
            // return false se conter caracater em branco (!) 
            return !RegexHelpers.notSpacesCharacters.IsMatch(password);
        }

        /// <summary>
        /// Validar digitos
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool OneOrMoreDigits(string password)
        {
            return RegexHelpers.oneOrMoreDigits.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter minusculo
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool OneOrMoreLowerCaseLetter(string password)
        {
            return RegexHelpers.oneOrMoreLowerCaseLetter.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter maisculo
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool OneOrMoreUpperCaseLetter(string password)
        {
            return RegexHelpers.oneOrMoreUpperCaseLetter.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter repitido
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool RepeatedCharactersWithinTheSet(string password)
        {
            return password?.CountBy(c => c).Where(kvp => kvp.Value > 1).Count() == 0;
        }

        /// <summary>
        /// Validar caracter especial
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected override bool SpecialCharacter(string password)
        {
            return RegexHelpers.specialCharactersRegex.IsMatch(password);
        }
    }
}
