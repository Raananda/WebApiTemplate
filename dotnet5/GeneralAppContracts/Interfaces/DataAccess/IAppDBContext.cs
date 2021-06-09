using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GeneralAppContracts.Interfaces.DataAccess
{
    public interface IAppDBContext
    {
        DataSet Init();
    }
}
