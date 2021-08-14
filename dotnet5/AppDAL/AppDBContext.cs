using Contracts;
using Contracts.Interfaces;
using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Threading.Tasks;

namespace AppDAL
{
    [Register(Policy.Transient, typeof(IAppDBContext))]
    public class AppDBContext : IAppDBContext
    {
        private readonly IConfiguration _configuration;
        private readonly IInfraDAL _infraDAL;
        private string _connectionString;

        public AppDBContext(IConfiguration configuration, IInfraDAL infraDAL)
        {
            _configuration = configuration;
            _infraDAL = infraDAL;
            _connectionString = _configuration.GetConnectionString("Default");
        }

        public async Task<AppInitResponseDTO> GetInitDataAsync()
        {
            var Response = new AppInitResponseDTO
            {
                Data1 = "This is data 1",
                Data2 = 999

            };

            var connection = _infraDAL.GetConnection(_connectionString);

            //// Array example
            var p_userID = _infraDAL.GetParameter("UserID", 12);
            var p_userID2 = _infraDAL.GetParameter("UserID2", 13);
            var Response1 = await Task.Run(() => _infraDAL.Exec(connection, "", "film_in_stock", p_userID, p_userID2));

            // List example
            //var parameterList = _infraDAL.GetParametersList();
            //parameterList.Add("l_first_name", "raanan");
            //parameterList.Add("l_Id", 123456);
            //var Response2 = _infraDAL.Exec(connection, "", "ffilm_in_stock", parameterList);


            // Mapping with automapper

            return Response;
        }


    }
}
