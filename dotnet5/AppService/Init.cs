using Contracts;
using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.BusinessLogic;
using GeneralAppContracts.Interfaces.DataAccess;

namespace AppService
{
    [Register(Policy.Transient, typeof(IInitService))]
    public class InitService : IInitService
    {
        private readonly IAppRepository _appRepository;

        public InitService(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public AppInitDTO GetInitData()
        {
            throw new System.NotImplementedException();
        }
    }
}
