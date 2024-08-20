
using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Data;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        //public async Task<List<UserModel>> GetAll()
        //{
        //    string storedProcedure = "spUser_SelectAll";

        //    using (var connection = this._dapperDBContext.CreateConnection()) 
        //    {
        //        var userList = await connection.QueryAsync<UserModel>(storedProcedure, 
        //                                    commandType: CommandType.StoredProcedure);
        //        return userList.ToList();
        //    }
        //}

        public async Task<UserModel?> GetById(string UserId)
        {
            string storedProcedure = "spUser_SelectById";

            //  using (var connection = this._dapperDBContext.CreateConnection())
            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_userId", UserId, DbType.String);

                var user = await connection.QuerySingleOrDefaultAsync<UserModel>(
                    storedProcedure,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return user;
            }
        }

        //public async Task<int> InsertNew(UserModel user)
        //{
        //    string storedProcedure = "spUser_InsertNew";

        //    using (var connection = this._dapperDBContext.CreateConnection())
        //    {
        //        var parameters = new DynamicParameters();
        //        parameters.Add("p_userId", user.UserId, DbType.String);
        //        parameters.Add("p_emailAddress", user.EmailAddress, DbType.String);
        //        parameters.Add("p_accountPassword", user.AccountPassword, DbType.String);
        //        parameters.Add("p_position", user.Position, DbType.String);

        //        return await connection.ExecuteAsync(storedProcedure, parameters, 
        //                                        commandType: CommandType.StoredProcedure);
        //    }
        //}

        //public async Task<int> UpdateAccountPassword(UserModel user)
        //{
        //    string storedProcedure = "spUser_UpdateUserPassword";

        //    using (var connection = this._dapperDBContext.CreateConnection())
        //    {
        //        var parameters = new DynamicParameters();
        //        parameters.Add("p_userId", user.UserId, DbType.String);
        //        parameters.Add("p_accountPassword", user.AccountPassword, DbType.String);

        //        return await connection.ExecuteAsync(storedProcedure, parameters, 
        //                                        commandType: CommandType.StoredProcedure);
        //    }
        //}

        //public async Task<int> DeleteUser(string UserId)
        //{
        //    string storedProcedure = "spUser_DeleteById";

        //    using (var connection = this._dapperDBContext.CreateConnection())
        //    {
        //        var parameters = new DynamicParameters();
        //        parameters.Add("p_userId", UserId, DbType.String);

        //        return await connection.ExecuteAsync(storedProcedure, parameters,
        //                                commandType: CommandType.StoredProcedure);
        //    }
        //}
    }
}
