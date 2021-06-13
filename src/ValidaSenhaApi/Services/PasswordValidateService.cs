using MoreLinq;
using System.Collections.Generic;
using System.Linq;
using ValidaSenhaApi.Helpers;

namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class PasswordValidateService : Password, IPasswordValidateService
    {

        /// <summary>
        /// Valitate Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Validate(string password)
        {

            //List<bool> validate = new List<bool>
            //{
            //    NimeOrMoreCharacters(password),
            //    OneOrMoreDigits(password)
            //};

            //bool b = !validate.Contains(false);

            //Nove ou mais caracteres
            bool valid = NimeOrMoreCharacters(password);
            if (valid == false) return false;

            //Ao menos 1 dígito
            valid = OneOrMoreDigits(password);
            if (valid == false) return false;

            //Ao menos 1 letra minúscula
            valid = OneOrMoreLowerCaseLetter(password);
            if (valid == false) return false;

            //Ao menos 1 letra maiúscula
            valid = OneOrMoreUpperCaseLetter(password);
            if (valid == false) return false;

            //Ao menos 1 caractere especial !@#$%^&*()-+
            valid = SpecialCharacter(password);
            if (valid == false) return false;

            //Não possuir caracteres repetidos dentro do conjunto
            valid = RepeatedCharactersWithinTheSet(password);
            if (valid == false) return false;

            //Espaços em branco não devem ser considerados como caracteres válidos.
            return NotSpacesCharacters(password);                       
        }


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
