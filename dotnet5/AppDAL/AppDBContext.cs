using Contracts;
using Contracts.Interfaces;
using Dapper;
using GeneralAppContracts.DataTransferObjects;
using GeneralAppContracts.Interfaces.DataAccess;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public async Task<List<AppInitResponseDTO>> GetInitDataAsync()
        {
            var Response = new AppInitResponseDTO
            {
                Data1 = "This is data 1",
                Data2 = 999,
                Data3 = 234324

            };


            // List example
            //var parameterList = _infraDAL.GetParametersList();
            //parameterList.Add("l_first_name", "raanan");
            //parameterList.Add("l_Id", 123456);
            //var Response2 = _infraDAL.Exec(connection, "", "ffilm_in_stock", parameterList);


            // Mapping with automapper


            #region DAL INFRA
            //  DAL INFRA
            // var connection = _infraDAL.GetConnection(_connectionString);
            // Execute SQL query
            // var Response2 = await Task.Run(() => _infraDAL.ExecSQL(connection, "select t.* from db_template.init t"));

            // Execute SP
            // var Response2 = await Task.Run(() => _infraDAL.ExecSP(connection, "db_template.get_init_data", _infraDAL.GetParametersList()));
            #endregion

            #region DAPPER SQL
            // DAPPER SQL
            // string sql = "select t.* from db_template.init t";
            // using (var connection = new MySqlConnection(_connectionString))
            //{
            //    var Response2 = await connection.QueryAsync<AppInitResponseDTO>(sql).ConfigureAwait(false);           

            //    return Response2.ToList();
            //}
            #endregion

            #region DAPPER SP
            //DAPPER SP
            string sql = "db_template.get_init_data";

            using (var connection = new MySqlConnection(_connectionString))
            {
                var Params = new
                {
                    l_data3 = 111
                };
                var Response2 = await connection.QueryAsync<AppInitResponseDTO>(sql, Params, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
                return Response2.ToList();
            }
            #endregion
        }


    }
}
