using Contracts;
using GeneralAppContracts.Interfaces.BusinessLogic;
using System;

namespace EmployeeBLL
{
    [Register(Policy.Transient, typeof(IEmployeeCrudOperations))]
    public class EmployeeService
    {
    }
}
