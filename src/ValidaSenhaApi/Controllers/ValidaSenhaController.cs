using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ValidaSenhaApi.Models;
using ValidaSenhaApi.Services;

namespace MeusInvestimentosApi.Controllers
{
    /// <summary>
    /// DashBoard Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValidaSenhaController : ControllerBase
    {
        private readonly IPasswordValidateService _passwordValidate;

        /// <summary>
        /// Cosnstructor
        /// </summary>
        /// <param name="passwordValidateService"></param>
        public ValidaSenhaController(IPasswordValidateService passwordValidateService)
        {
            _passwordValidate = passwordValidateService;
        }


        /// <summary>
        /// Nove ou mais caracteres,    
        /// Ao menos 1 dígito,
        /// Ao menos 1 letra minúscula,
        /// Ao menos 1 letra maiúscula,
        /// Ao menos 1 caractere especial, 
        /// Não possuir caracteres repetidos dentro do conjunto,
        /// Não possuir espaços em branco
        /// </summary>
        /// <param name="request">password</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Validade([FromBody] PasswordRequest request)
        {
            var valid = await Task.FromResult(_passwordValidate.Validate(request.Password));
            return Ok(valid);
        }
    }
}
