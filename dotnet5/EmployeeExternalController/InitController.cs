using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppExternalController
{
    [ApiController]
    [Route("api/[controller]/{Action}")]
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
        public AppInitResponseDTO GetInit()
        {
            return _initService.GetInitData();           
        }

    }
}
