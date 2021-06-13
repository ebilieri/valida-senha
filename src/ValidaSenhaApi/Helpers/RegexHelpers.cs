using System.Text.RegularExpressions;

namespace ValidaSenhaApi.Helpers
{
    /// <summary>
    /// Regex helpers
    /// </summary>
    public static class RegexHelpers
    {
        /// <summary>
        /// Valida se contem 9 ou mais caracteres
        /// </summary>
        public static readonly Regex nineOrMoreCharacters = new Regex(@"^(?=^.{9,}).*$", RegexOptions.Compiled);

        /// <summary>
        /// valida se contem  1 ou mais digitos
        /// </summary>
        public static readonly Regex oneOrMoreDigits = new Regex(@"^(?=.*[0-9]).*$", RegexOptions.Compiled);

        /// <summary>
        /// valida se contem  1 ou mais letra minúscula
        /// </summary>
        public static readonly Regex oneOrMoreLowerCaseLetter = new Regex(@"^(?=.*[a-z]).*$", RegexOptions.Compiled);

        /// <summary>
        /// valida se contem  1 ou mais letra maiúscula
        /// </summary>
        public static readonly Regex oneOrMoreUpperCaseLetter = new Regex(@"^(?=.*[A-Z]).*$", RegexOptions.Compiled);

        /// <summary>
        /// Valida se contem pelo menos 1 caracter especial
        /// </summary>
        public static readonly Regex specialCharactersRegex = new Regex(@"!|@|#|\$|%|\^|&|\*|\(|\)|-|\+", RegexOptions.Compiled);

        /// <summary>
        /// Valida se  possui caracteres repetidos dentro do conjunto
        /// </summary>
        public static readonly Regex notSpacesCharacters = new Regex(@"\s+", RegexOptions.Compiled);
    }
}
