using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GeneralAppContracts.Interfaces.DataAccess
{
    public interface IEmployeeDBContext
    {
        DataSet GetEmployee(int ID);
    }
}
