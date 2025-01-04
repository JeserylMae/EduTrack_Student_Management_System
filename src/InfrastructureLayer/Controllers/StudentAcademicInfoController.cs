using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
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
            _studentQuery = new StudentAcadInfoQuery();
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<PStudentAcademicInfoModel<PNameModel>> response = await _studentAcademicRepository.GetAll();

            if (response.Count > 0) return Ok(response);
            return NotFound(new { Message = "An error occurred. Failed to load Student Academic Information page." });
        }

        [HttpGet("GetAllSections")]
        public async Task<IActionResult> GetAllSections()
        {
            string procedure = _studentQuery.spGetAllDistict("Section");
            var response = await _studentAcademicRepository.GetAllDistinct(procedure);

            if (response.Count > 0 && response != null) return Ok(response);
            return NotFound(new { Message = "Failed to retrieve sections." });
        }

        [HttpGet("GetRecordId")]
        public async Task<IActionResult> GetRecordId([FromQuery]PRStudentAcademicInfoParams paramsModel)
        {
            int response = await _studentAcademicRepository.GetRecordId(paramsModel);

            if (response > 0) return Ok(new { RecordId = response });
            return NotFound(new { Message = "Failed to find record id." });
        }

        [HttpGet("GetByParams")]
        public async Task<IActionResult> GetByParams([FromQuery]PRStudentAcademicInfoParams? studentModel)
        {
            if (studentModel == null) return BadRequest(new { Message = "At least one parameter must be filled." });

            PStudentAcademicInfoModel<PNameModel> response = await _studentAcademicRepository.GetByParams(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Student with Sr-Code {studentModel.SrCode} not found." });
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PStudentAcademicInfoModel<string> studentModel)
        {
            int response = await _studentAcademicRepository.InsertNew(studentModel);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to add student with Sr-Code {studentModel.SrCode}." });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update([FromBody]PStudentAcademicInfoModel<string> studentModel, [FromQuery]int dataId)
        {
            int response = await _studentAcademicRepository.Update(studentModel, dataId);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to update student with Sr-Code {studentModel.SrCode}" });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(PRStudentAcademicInfoParams? studentModel)
        {
            if (studentModel == null)
                return BadRequest(new { Message = "At least one parameter must be filled." });

            int response = await _studentAcademicRepository.DeleteStudent(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Failed to delete student with Sr-Code {studentModel.SrCode}." });
        }


        private StudentAcadInfoQuery _studentQuery;
        private IStudentAcademicInfoRepository _studentAcademicRepository;
    }
}
