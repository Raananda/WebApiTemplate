using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AppExternalController
{
    [ApiController]
    [Route("api/[controller]")]
    public class InitController : ControllerBase
    {

        private readonly ILogger<InitController> _logger;
        private readonly IInitService _initService;

        public InitController(ILogger<InitController> logger, IInitService initService)
        {
            _logger = logger;
            _initService = initService;
        }

        [HttpGet]
        [Route("GetInit")]
        public async  Task<ActionResult<AppInitResponseDTO>> GetInit()
        {
           // return BadRequest();
            return await _initService.GetInitDataAsync();          
        }

    }
}
