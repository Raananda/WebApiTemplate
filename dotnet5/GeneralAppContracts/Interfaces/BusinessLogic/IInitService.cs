using GeneralAppContracts.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAppContracts.Interfaces.BusinessLogic
{
    public interface IInitService
    {
        Task<AppInitResponseDTO> GetInitDataAsync();
    }
}
