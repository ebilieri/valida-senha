namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class PasswordValidateService :  IPasswordValidateService
    {
        /// <summary>
        /// Valitate Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Validate(string password)
        {
            PasswordValidate passwordValidate = new PasswordValidate();
            return passwordValidate.Validate(password);
        }
    }
}
