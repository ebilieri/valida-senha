using MoreLinq;
using System.Linq;
using ValidaSenhaApi.Helpers;

namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// PasswordValidate
    /// </summary>
    public sealed class PasswordValidate
    {

        /// <summary>
        /// Valitate Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Validate(string password)
        {

            //Nove ou mais caracteres
            if (NimeOrMoreCharacters(password) == false) return false;

            //Ao menos 1 dígito
            if (OneOrMoreDigits(password) == false) return false;

            //Ao menos 1 letra minúscula
            if (OneOrMoreLowerCaseLetter(password) == false) return false;

            //Ao menos 1 letra maiúscula
            if (OneOrMoreUpperCaseLetter(password) == false) return false;

            //Ao menos 1 caractere especial !@#$%^&*()-+
            if (SpecialCharacter(password) == false) return false;

            //Não possuir caracteres repetidos dentro do conjunto
            if (RepeatedCharactersWithinTheSet(password) == false) return false;

            //Espaços em branco não devem ser considerados como caracteres válidos.
            return NotSpacesCharacters(password);
        }



        // Private Methods

        /// <summary>
        /// Validar quantidade de caracteres
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool NimeOrMoreCharacters(string password)
        {
            return RegexHelpers.nineOrMoreCharacters.IsMatch(password);
        }

        /// <summary>
        /// Validar caracteres em branco
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool NotSpacesCharacters(string password)
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
        private bool OneOrMoreDigits(string password)
        {
            return RegexHelpers.oneOrMoreDigits.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter minusculo
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool OneOrMoreLowerCaseLetter(string password)
        {
            return RegexHelpers.oneOrMoreLowerCaseLetter.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter maisculo
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool OneOrMoreUpperCaseLetter(string password)
        {
            return RegexHelpers.oneOrMoreUpperCaseLetter.IsMatch(password);
        }

        /// <summary>
        /// Validar caracter repitido
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool RepeatedCharactersWithinTheSet(string password)
        {
            return password?.CountBy(c => c).Where(kvp => kvp.Value > 1).Count() == 0;
        }

        /// <summary>
        /// Validar caracter especial
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool SpecialCharacter(string password)
        {
            return RegexHelpers.specialCharactersRegex.IsMatch(password);
        }
    }
}
