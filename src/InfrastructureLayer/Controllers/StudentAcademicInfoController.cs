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


        private IStudentAcademicInfoRepository _studentAcademicRepository;
    }
}
