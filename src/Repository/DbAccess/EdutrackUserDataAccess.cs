using DomainLayer.Models.DerivedModel;

namespace WebService.DbAccess
{
    public class EdutrackUserDataAccess : IEdutrackUserDataAccess
    {
        public EdutrackUserDataAccess(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<IEdutrackUserModel>> GetUsers() =>
            _db.LoadData<IEdutrackUserModel, dynamic>("spUser_GetAll", new { });

        public async Task<IEdutrackUserModel?> GetUser(string UserId)
        {
            var results = await _db.LoadData<IEdutrackUserModel, dynamic>("spUser_GetById", new { UserId = UserId });

            return results.FirstOrDefault();
        }

        public Task InsertUser(IEdutrackUserModel edutrackUserModel) =>
            _db.SaveData("spUser_Insert", edutrackUserModel);

        public Task UpdateUser(IEdutrackUserModel edutrackUserModel) =>
            _db.SaveData("spUser_Update", edutrackUserModel);

        public Task DeleteUser(string UserId) =>
            _db.SaveData("spUser_Delete", new { UserId = UserId });

        private ISqlDataAccess _db;
    }
}
