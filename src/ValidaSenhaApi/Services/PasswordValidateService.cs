namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class PasswordValidateService : PasswordValidate, IPasswordValidateService
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
    }
}
