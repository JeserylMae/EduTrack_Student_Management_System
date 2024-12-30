using DomainLayer.DataModels;

namespace InfrastructureLayer.Database
{
    public interface IProgramRepository
    {
        Task<int> Delete(string ProgramId);
        Task<List<PRProgramModel>> GetAll();
        Task<Dictionary<dynamic, dynamic>> GetAllProgram();
        Task<int> InsertNew(PRProgramModel programModel);
        Task<int> Update(PRProgramModel programModel);
        Task<int> UpdateProgramId(PRProgramModel programModel);
    }
}