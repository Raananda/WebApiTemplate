using Contracts;
using Contracts.Interfaces;
using GeneralAppContracts.Interfaces.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;

namespace AppDAL
{
    [Register(Policy.Transient, typeof(IAppDBContext))]
    public class AppDBContext: IAppDBContext
    {
        //private readonly IConfiguration _configuration;
        //private string _connectionString;
      //  readonly IInfraDAL _dal;

        //public AppDBContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    _connectionString = _configuration.GetConnectionString("Default");
        //}

        public DataSet Init()
        {
          //  var connection = _dal.GetConnection(_connectionString);

            //// Array example
            //var p_userID = _dal.GetParameter("UserID", 12);
            //var p_userID2 = _dal.GetParameter("UserID2", 13);
            //var Response1 = _dal.Exec(connection, "PACKAGE", "STORED_PROCEDURE", p_userID, p_userID2);

            ////List example
            //var parameterList = _dal.GetParametersList();
            //parameterList.Add("l_first_name", "raanan");
            //parameterList.Add("l_Id", 123456);
            //var Response2 = _dal.Exec(connection, "PACKAGE", "STORED_PROCEDURE", parameterList);
            //return Response1;

            return new DataSet();
        }
    }
}
