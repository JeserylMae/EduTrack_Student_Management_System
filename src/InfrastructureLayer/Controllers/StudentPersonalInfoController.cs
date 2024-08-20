
using DomainLayer.DataModels;
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
            List<StudentPersonalInfoModel> userList = await _studentPersonalInfoRepository.GetAll();

            if (userList is not null) { return Ok(userList); }
            else { return NotFound(); }  
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNewStudentPersonalInfo(StudentPersonalInfoModel studentPersonalInfo,
                                                            string DefaultPassword, string Position,
                                                            string StudentCode, string GuardianCode)
        {
            int result = await _studentPersonalInfoRepository.InsertNew(studentPersonalInfo,
                                       DefaultPassword, Position, StudentCode, GuardianCode);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest( new { Message = $"Failed to add student with SR-Code {studentPersonalInfo.SrCode}."}); }
        }


        private IStudentPersonalInfoRepository _studentPersonalInfoRepository;
    }
}
