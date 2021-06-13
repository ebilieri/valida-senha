using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
        /// 
        /// </summary>
        public ValidaSenhaController(IPasswordValidateService passwordValidateService)
        {
            _passwordValidate = passwordValidateService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Validade(string password)
        {

            var valid = await Task.FromResult(_passwordValidate.Validate(password));
            return Ok(valid);
        }
    }
}
