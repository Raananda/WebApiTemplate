using GeneralAppContracts.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAppContracts.Interfaces.BusinessLogic
{
    public interface IInitService
    {
        AppInitResponseDTO GetInitData();
    }
}
