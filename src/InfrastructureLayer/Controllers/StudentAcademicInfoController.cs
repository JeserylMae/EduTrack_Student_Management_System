using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Presenters.Enumerations;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAcademicInfoController : ControllerBase
    {
        public StudentAcademicInfoController(IDataRepository dataRepository, 
                    IStudentAcademicInfoRepository studentAcademicRepository)
        {
            _repository = dataRepository;
            _query = new StudentAcadInfoQuery();
            _studentRepository = studentAcademicRepository;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<PStudentAcademicInfoModel<PNameModel>> response = await _studentRepository.GetAll();
                       
            if (response.Count > 0) return Ok(response);
            return NotFound(new { Message = "An error occurred. Failed to load Student Academic Information page." });
        }

        [HttpGet("GetAllSections")]
        public async Task<IActionResult> GetAllSections()
        {
            string procedure = _query.spGetAllDistict("Section");
            var response = await _repository.GetAll<string>(procedure);

            if (response.Count > 0 && response != null) return Ok(response);
            return NotFound(new { Message = "Failed to retrieve sections." });
        }

        [HttpGet("GetRecordId")]
        public async Task<IActionResult> GetRecordId([FromQuery]PRStudentAcademicInfoParams paramsModel)
        {
            string procedure = _query.spGetRecordId;

            DynamicParameters parameters = new DynamicParameters();
            _studentRepository.AddDynamicParameters(ref parameters,
                StudentAcadParams.SrCodeAndAcadYearAndYearLevelAndSemester,
                paramsModel);

            int response = await _repository.GetSingle<int>(procedure, parameters);

            if (response > 0) return Ok(new { RecordId = response });
            return NotFound(new { Message = "Failed to find record id." });
        }

        [HttpGet("GetByParams")]
        public async Task<IActionResult> GetByParams([FromQuery]PRStudentAcademicInfoParams? studentModel)
        {
            if (studentModel == null) return BadRequest(new { Message = "At least one parameter must be filled." });

            PStudentAcademicInfoModel<PNameModel> response = await _studentRepository.GetByParams(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Student with Sr-Code {studentModel.SrCode} not found." });
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PStudentAcademicInfoModel<string> studentModel)
        {
            string procedure = _query.spInsertNew;

            DynamicParameters parameters = new DynamicParameters();
            _studentRepository.AddDynamicParameters(
                ref parameters, 
                studentModel, 
                RequestType.INSERT
            );

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to add student with Sr-Code {studentModel.SrCode}." });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update([FromBody]PStudentAcademicInfoModel<string> studentModel, [FromQuery]int dataId)
        {
            string procedure = _query.spUpdate;

            DynamicParameters parameters = new DynamicParameters();
            _studentRepository.AddDynamicParameters(
                ref parameters, 
                studentModel, 
                RequestType.UPDATE, 
                dataId
            );

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"An error occured! Failed to update student with Sr-Code {studentModel.SrCode}" });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(PRStudentAcademicInfoParams? studentModel)
        {
            if (studentModel == null)
                return BadRequest(new { Message = "At least one parameter must be filled." });

            int response = await _studentRepository.DeleteStudent(studentModel);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"Failed to delete student with Sr-Code {studentModel.SrCode}." });
        }


        private StudentAcadInfoQuery _query;
        private IDataRepository _repository;
        private IStudentAcademicInfoRepository _studentRepository;
    }
}
