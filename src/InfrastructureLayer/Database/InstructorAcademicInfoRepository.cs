
using Dapper;
using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using InfrastructureLayer.Data;
using InfrastructureLayer.Query;
using System.Data;

namespace InfrastructureLayer.Database
{
    public class InstructorAcademicInfoRepository : IInstructorAcademicInfoRepository
    {
        public InstructorAcademicInfoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _query = new InstructorAcademicInfoQuery();
        }


        public async Task<List<PInstructorAcademicInfoModel<PNameModel>>> GetAll()
        {
            string procedure = _query.spGetAll;

            using (IDbConnection connection = _databaseContext.CreateConnection())
            {
                var result = await connection.QueryAsync<PInstructorAcademicInfoModel<PNameModel>,
                                             PNameModel, PInstructorAcademicInfoModel<PNameModel>>(
                    procedure,
                    (academicInfo, name) =>
                    {
                        academicInfo.InstructorName = name;
                        return academicInfo;
                    }, splitOn: "LastName",
                    commandType: CommandType.Text
                );
                return result.ToList();
            }
        }

       

        private DatabaseContext _databaseContext;
        private InstructorAcademicInfoQuery _query;
    }
}
