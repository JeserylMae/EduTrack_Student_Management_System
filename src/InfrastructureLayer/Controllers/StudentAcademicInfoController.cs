using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAcademicInfoController : ControllerBase
    {
        public StudentAcademicInfoController(IStudentAcademicInfoRepository studentAcademicInfoRepository)
        {
            _studentAcademicRepository = studentAcademicInfoRepository;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<RStudentAcademicInfoModel> response = await _studentAcademicRepository.GetAll();

            if (response.Count > 0) return Ok(response);
            return NotFound(new { Message = "An error occurred. Failed to load Student Academic Information page." });
        }

        [HttpGet("GetByParams")]
        public async Task<IActionResult> GetByParams([FromQuery]PStudentAcadInfoParams? studentModel)
        {
            if (studentModel == null) return BadRequest(new { Message = "At least one parameter must be filled." });

            RStudentAcademicInfoModel response = await _studentAcademicRepository.GetByParams(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Student with Sr-Code {studentModel.SrCode} not found." });
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(RStudentAcademicInfoModel studentModel)
        {
            int response = await _studentAcademicRepository.InsertNew(studentModel);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to add student with Sr-Code {studentModel.SrCode}." });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update(RStudentAcademicInfoModel studentModel)
        {
            int response = await _studentAcademicRepository.Update(studentModel);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to update student with Sr-Code {studentModel.SrCode}" });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(PStudentAcadInfoParams? studentModel)
        {
            if (studentModel == null)
                return BadRequest(new { Message = "At least one parameter must be filled." });

            int response = await _studentAcademicRepository.DeleteStudent(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Failed to delete student with Sr-Code {studentModel.SrCode}." });
        }


        private IStudentAcademicInfoRepository _studentAcademicRepository;
    }
}
