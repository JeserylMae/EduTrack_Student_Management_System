using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using System.Data;
using System.Data.Common;

namespace InfrastructureLayer.Database
{
    public class MProgramRepository : IProgramRepository
    {
        public MProgramRepository(DatabaseContext databaseContext)
        {
            _programQuery = new ProgramQuery();
            _databaseContext = databaseContext;
        }


        public async Task<List<PRProgramModel>> GetAll()
        {
            string procedure = _programQuery.GetAll;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<PRProgramModel>(
                    procedure, commandType: CommandType.Text
                );
                return result.ToList();
            }
        }

        public async Task<Dictionary<dynamic, dynamic>> GetAllProgram()
        {
            string procedure = _programQuery.GetAllProgram;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync(
                    procedure, commandType: CommandType.Text
                );
                return result.ToDictionary(
                    row => (dynamic)row.ProgramId,
                    row => (dynamic)row.ProgramName 
                );
            }
        }

        public async Task<int> InsertNew(PRProgramModel programModel)
        {
            string procedure = _programQuery.InsertNew;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, programModel);

                return await connection.ExecuteAsync(
                    procedure, parameters,
                    commandType: CommandType.Text);
            }
        }

        public async Task<int> Update(PRProgramModel programModel)
        {
            string procedure = _programQuery.Update;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, programModel);

                return await connection.ExecuteAsync(
                    procedure, parameters,
                    commandType: CommandType.Text);
            }
        }

        public async Task<int> UpdateProgramId(PRProgramModel programModel)
        {
            string procedure = _programQuery.UpdateProgramId;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                AddDynamicParameters(ref parameters, programModel);

                return await connection.ExecuteAsync(
                    procedure, parameters,
                    commandType: CommandType.Text
                );
            }
        }

        public async Task<int> Delete(string ProgramId)
        {
            string procedure = _programQuery.Delete;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@p_ProgramId", ProgramId);

                return await connection.ExecuteAsync(
                    procedure, parameters,
                    commandType: CommandType.Text
                );
            }
        }


        #region Helpers
        private void AddDynamicParameters(ref DynamicParameters parameters, PRProgramModel programModel)
        {
            parameters.Add("@p_ProgramId", programModel.ProgramId);
            parameters.Add("@p_ProgramName", programModel.ProgramName);
            parameters.Add("@p_DepartmentId", programModel.DepartmentId);
            parameters.Add("@p_DepartmentName", programModel.DepartmentName);
        }
        #endregion


        private ProgramQuery _programQuery;
        private DatabaseContext _databaseContext;
    }
}
