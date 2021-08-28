using Contracts;
using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.BusinessLogic;
using GeneralAppContracts.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBLL
{
    [Register(Policy.Transient, typeof(IInitService))]
    public class InitService : IInitService
    {
        private readonly IAppDBContext _appDBContext;

        public InitService(IAppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<List<AppInitResponseDTO>> GetInitDataAsync()
        {        
            return await _appDBContext.GetInitDataAsync();
        }
    }
}
