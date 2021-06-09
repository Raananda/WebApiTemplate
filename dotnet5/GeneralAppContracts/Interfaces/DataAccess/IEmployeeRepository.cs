using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAppContracts.Interfaces.DataAccess
{
    public interface IEmployeeRepository
    {
        string Get(int ID);
    }
}
