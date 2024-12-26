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


        private IStudentAcademicInfoRepository _studentAcademicRepository;
    }
}
