
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
            List<RStudentPersonalInfoModel> userList = await _studentPersonalInfoRepository.GetAll();

            if (userList is not null) { return Ok(userList); }
            else { return NotFound(); }  
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetStudentPersonalInfoById(string SrCode)
        {
            RStudentPersonalInfoModel student = await _studentPersonalInfoRepository.GetById(SrCode);

            if (student is not null) { return Ok(student); }
            else { return NotFound(new { Message = $"Student with SR Code {SrCode} is not found."}); }
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNewStudentPersonalInfo(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            int result = await _studentPersonalInfoRepository.InsertNew(student);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest( new { Message = $"Failed to add student with SR-Code {student.InfoModel.SrCode}."}); }
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateStudentPersonalInfo(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            int result = await _studentPersonalInfoRepository.Update(student);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest(new { Message = $"Failed to update student with SR-Code {student.InfoModel.SrCode}."}); }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteStudentPersonalInfo([FromBody] PStudentPersonalInfoCodeModel codes)
        {
            int result = await _studentPersonalInfoRepository.DeleteById(codes);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest(new { Message = $"Falied to delete information of student with Sr-Code {codes.SrCode}." }); }
        }


        private IStudentPersonalInfoRepository _studentPersonalInfoRepository;
    }
}
