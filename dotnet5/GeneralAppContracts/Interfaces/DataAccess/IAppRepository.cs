using GeneralAppContracts.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAppContracts.Interfaces.DataAccess
{
   public interface IAppRepository
    {
        AppInitDTO Init();
    }
}
