namespace ValidaSenhaApi.Services
{
    /// <summary>
    /// Class abstract Password
    /// </summary>
    public abstract class Password
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool NimeOrMoreCharacters(string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool OneOrMoreDigits(string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool OneOrMoreLowerCaseLetter(string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool OneOrMoreUpperCaseLetter(string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool SpecialCharacter(string password);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool RepeatedCharactersWithinTheSet(string password);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        protected abstract bool NotSpacesCharacters(string password);


    }
}
