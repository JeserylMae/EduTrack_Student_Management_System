
using Dapper;
using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Presenters.Enumerations;
using System.Data;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorAcademicInfoController : ControllerBase
    {
        public InstructorAcademicInfoController(IDataRepository dataRepository, 
                                InstructorAcademicInfoRepository itrRepository)
        {
            _repository = dataRepository;
            _itrRepository = itrRepository;
            _query = new InstructorAcademicInfoQuery();
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _itrRepository.GetAll();

            if (response != null) return Ok(response);
            else return NotFound(new { Message = $"Failed to get list of instructor's academic info." });
        }

        [HttpGet("GellAllCourse")]
        public async Task<IActionResult> GetAllSection()
        {
            string procedure = _query.spGetAllDistinct("Section");

            var response = await _repository.GetAll<List<string>>(procedure);

            if (response != null) return Ok(response);
            else return NotFound(new { Message = "Failed to get sections." });
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(PRInstructorAcademicParams? instructor)
        {
            if (instructor == null) return BadRequest(new { Message = "At least one parameter is required." });

            InstructorAcadParams parametersType = HandleParameters(instructor);
            string procedure = _query.spGetById(parametersType);
            
            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameter(ref parameters, instructor);

            var response = await _repository.GetSingle<PInstructorAcademicInfoModel<PNameModel>>(procedure, parameters);

            if (response != null) return Ok(response);
            else return NotFound(new { Message = $"Failed to get instructor with ID {instructor.ItrCode}." });
        }

        [HttpGet("GetRecordId")]
        public async Task<IActionResult> GetRecordId(PRInstructorAcademicParams instructor)
        {
            string procedure = _query.spGetRecordId;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameter(ref parameters, instructor);

            string response = await _repository.GetSingle<string>(procedure, parameters);

            if (response != null) return Ok(response);
            else return NotFound(new { Message = $"Failed to get the record ID of instructor with ID {instructor.ItrCode}." });
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PInstructorAcademicInfoModel<string> instructor)
        {
            string procedure = _query.spInsertNew;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameter<string>(ref parameters, instructor);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            else return BadRequest(new { Message = "Failed to insert new instructor information." });
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> Update([FromQuery] string recordId,
                [FromBody] PInstructorAcademicInfoModel<string> instructor)
        {
            string procedure = _query.spUpdate;

            DynamicParameters parameters = new DynamicParameters(); 
            AddValuesToParameter<string> (ref parameters, instructor);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            else return BadRequest(new { Message = $"Failed to update instructor with ID {instructor.ItrCode}." });
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(PRInstructorAcademicParams instructor)
        {
            InstructorAcadParams parameterType = HandleParameters(instructor);
            string procedure = _query.spDelete(parameterType);

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameter(ref parameters, instructor);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            else return BadRequest(new { Message = $"Failed to delete information of instructor with ID {instructor.ItrCode}." });
        }


        #region Helpers
        private InstructorAcadParams HandleParameters(PRInstructorAcademicParams parameters)
        {
            if (!string.IsNullOrEmpty(parameters.ItrCode)      &&
                !string.IsNullOrEmpty(parameters.AcademicYear) &&
                !string.IsNullOrEmpty(parameters.YearLevel)    &&
                !string.IsNullOrEmpty(parameters.Semester)     &&
                !string.IsNullOrEmpty(parameters.Section)      &&
                !string.IsNullOrEmpty(parameters.Course))
            {
                return InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemesterAndSectionAndCourse;
            }
            else if (!string.IsNullOrEmpty(parameters.ItrCode)      &&
                     !string.IsNullOrEmpty(parameters.AcademicYear) &&
                     !string.IsNullOrEmpty(parameters.YearLevel)    &&
                     !string.IsNullOrEmpty (parameters.Semester)    &&
                     !string.IsNullOrEmpty(parameters.Section))
            {
                return InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemesterAndSection;
            }
            else if (!string.IsNullOrEmpty(parameters.ItrCode)      &&
                     !string.IsNullOrEmpty(parameters.AcademicYear) &&
                     !string.IsNullOrEmpty(parameters.YearLevel)    &&
                    !string.IsNullOrEmpty(parameters.Semester))
            {
                return InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemester;
            }
            else if (!string.IsNullOrEmpty(parameters.ItrCode)      &&
                     !string.IsNullOrEmpty(parameters.AcademicYear) &&
                     !string.IsNullOrEmpty(parameters.YearLevel))
            {
                return InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevel;
            }
            else if (!string.IsNullOrEmpty(parameters.ItrCode)      &&
                     !string.IsNullOrEmpty(parameters.AcademicYear))
            {
                return InstructorAcadParams.ItrCodeAndAcademicYear;
            }
            else if (!string.IsNullOrEmpty(parameters.ItrCode))
            {
                return InstructorAcadParams.ItrCode;
            }
            else { return InstructorAcadParams.None;}
        }

        private void AddValuesToParameter(ref DynamicParameters parameters, 
                                    PRInstructorAcademicParams instructor)
        {
            parameters.Add("@p_ItrCode", instructor.ItrCode);
            parameters.Add("@p_AcademicYear", instructor.AcademicYear);
            parameters.Add("@p_YearLevel", instructor.YearLevel);
            parameters.Add("@p_Semester", instructor.Semester);
            parameters.Add("@p_Section", instructor.Section);
            parameters.Add("@p_Course", instructor.Course);
        }

        private void AddValuesToParameter<TModel>(ref DynamicParameters parameters,
                    PInstructorAcademicInfoModel<TModel> instructor)
        {
            parameters.Add("@p_ItrCode",            instructor.ItrCode          );
            parameters.Add("@p_Course",             instructor.Course           );
            parameters.Add("@p_Program",            instructor.Program          );
            parameters.Add("@p_Section",            instructor.Section          );
            parameters.Add("@p_Semester",           instructor.Semester         );
            parameters.Add("@p_YearLevel",          instructor.YearLevel        );
            parameters.Add("@p_AcademicYear",       instructor.AcademicYear     );
            parameters.Add("@p_InstructorNameId",   instructor.InstructorName   );
        }
        #endregion


        private IDataRepository _repository;
        private InstructorAcademicInfoQuery _query;
        private IInstructorAcademicInfoRepository _itrRepository;
    }
}
