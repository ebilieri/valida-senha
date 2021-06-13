namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPasswordValidateService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Validate(string password);
    }
}