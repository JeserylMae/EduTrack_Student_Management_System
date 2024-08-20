
using InfrastructureLayer.Database;
using Microsoft.AspNetCore.Mvc;


namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPersonalInfoController : ControllerBase
    {
        public StudentPersonalInfoController(IStudentPersonalInfoRepository studentPersonalInfoRepository)
        {
            _studentPersonalInfoRepository = studentPersonalInfoRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllStudentPersonalInfo()
        {
            var userList = await _studentPersonalInfoRepository.GetAll();

            if (userList is not null) { return Ok(userList); }
            else { return NotFound(); }  
        }


        private IStudentPersonalInfoRepository _studentPersonalInfoRepository;
    }
}
