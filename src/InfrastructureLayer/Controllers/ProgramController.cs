using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        public ProgramController(IDataRepository dataRepository)
        {
            _query = new ProgramQuery();
            _repository = dataRepository;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            string procedure = _query.GetAll;
            List<PRProgramModel> response = await _repository.GetAll<PRProgramModel>(procedure);

            if (response.Count() > 0) return Ok(response);
            return NotFound(new { Message = "Failed to get program informations."});
        }

        [HttpGet("GetAllProgram")]
        public async Task<IActionResult> GetAllProgram()
        {
            string procedure = _query.GetAllProgram;
            Dictionary<dynamic, dynamic> response = await _repository.GetAll(procedure);

            if (response.Count() > 0) return Ok(response);
            return NotFound(new { Message = "Failed to get program list."});
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PRProgramModel programModel)
        {
            string procedure = _query.InsertNew;

            DynamicParameters parameters = new DynamicParameters();
            AddDynamicParameters(ref parameters, programModel);

            int response = await _repository.Execute(procedure, parameters);

            if(response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to add program with ID {programModel.ProgramId}" });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update(PRProgramModel programModel)
        {
            string procedure = _query.Update;
            
            DynamicParameters parameters = new DynamicParameters();
            AddDynamicParameters(ref parameters, programModel);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to update program with ID {programModel.ProgramId}" });
        }

        [HttpPatch("UpdateProgramId")]
        public async Task<IActionResult> UpdateProgramId(PRProgramModel programModel)
        {
            string procedure = _query.UpdateProgramId;

            DynamicParameters parameters = new DynamicParameters();
            AddDynamicParameters(ref parameters, programModel);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to update program {programModel.ProgramName}." });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(string programId)
        {
            string procedure = _query.Delete;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@p_ProgramId", programId);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to delete program with ID {programId}." });
        }


        #region Helpers
        private void AddDynamicParameters(ref DynamicParameters parameters, 
                                          PRProgramModel programModel)
        {
            parameters.Add("@p_ProgramId", programModel.ProgramId);
            parameters.Add("@p_ProgramName", programModel.ProgramName);
            parameters.Add("@p_DepartmentId", programModel.DepartmentId);
            parameters.Add("@p_DepartmentName", programModel.DepartmentName);
        }
        #endregion


        private ProgramQuery _query;
        private IDataRepository _repository;
    }
}
