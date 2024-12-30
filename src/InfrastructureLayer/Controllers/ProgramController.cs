using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        public ProgramController(IProgramRepository programRepository)
        {
            _programRepository = programRepository; 
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _programRepository.GetAll();

            if (response.Count() > 0) return Ok(response);
            return NotFound(new { Message = "Failed to get program informations."});
        }

        [HttpGet("GetAllProgram")]
        public async Task<IActionResult> GetAllProgram()
        {
            var response = await _programRepository.GetAllProgram();

            if (response.Count() > 0) return Ok(response);
            return NotFound(new { Message = "Failed to get program list."});
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PRProgramModel programModel)
        {
            var response = await _programRepository.InsertNew(programModel);

            if(response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to add program with ID {programModel.ProgramId}" });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update(PRProgramModel programModel)
        {
            var response = await _programRepository.Update(programModel);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to update program with ID {programModel.ProgramId}" });
        }

        [HttpPatch("UpdateProgramId")]
        public async Task<IActionResult> UpdateProgramId(PRProgramModel programModel)
        {
            var response = await _programRepository.UpdateProgramId(programModel);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to update program {programModel.ProgramName}." });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(string programId)
        {
            var response = await _programRepository.Delete(programId);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to delete program with ID {programId}." });
        }

        private IProgramRepository _programRepository;
    }
}
