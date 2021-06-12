using Contracts;
using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.BusinessLogic;
using GeneralAppContracts.Interfaces.DataAccess;
using System;

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

        public AppInitResponseDTO GetInitData()
        {        
            return _appDBContext.GetInitData();
        }
    }
}
