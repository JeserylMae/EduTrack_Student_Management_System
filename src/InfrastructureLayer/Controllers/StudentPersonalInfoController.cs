
using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Presenters.Enumerations;
using System.Data;


namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPersonalInfoController : ControllerBase
    {
        public StudentPersonalInfoController(IDataRepository dataRepository)
        {
            _repository = dataRepository;
            _query = new StudentPersonalInfoQuery();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            string procedure = _query.spGetAll;
            var userList = await _repository.GetAll<RStudentPersonalInfoModel>(procedure);

            if (userList is not null) { return Ok(userList); }
            else { return NotFound(); }  
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string SrCode)
        {
            string procedure = _query.spGetById;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@p_SrCode", SrCode, DbType.String);

            var student = await _repository.GetSingle<RStudentPersonalInfoModel>(procedure, parameters);

            if (student is not null) { return Ok(student); }
            else { return NotFound(new { Message = $"Student with SR Code {SrCode} is not found."}); }
        }

        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            string procedure = _query.spInsert;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref student, RequestType.INSERT);

            int result = await _repository.Execute(procedure, parameters);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest( new { Message = $"Failed to add student with SR-Code {student.InfoModel.SrCode}."}); }
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateStudentPersonalInfo(PStudentPersonalInfoModel<RStudentPersonalInfoModel> student)
        {
            string procedure = _query.spUpdate;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref student, RequestType.UPDATE);

            int result = await _repository.Execute(procedure, parameters);

            if (result is not 0) { return Ok(result); }
            else { return BadRequest(new { Message = $"Failed to update student with SR-Code {student.InfoModel.SrCode}."}); }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteStudentPersonalInfo([FromBody] PStudentPersonalInfoParams codes)
        { 
            string procedure = _query.spDelete;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref codes);

            int result = await _repository.Execute(procedure, parameters);  

            if (result is not 0) { return Ok(result); }
            else { return BadRequest(new { Message = $"Falied to delete information of student with Sr-Code {codes.SrCode}." }); }
        }


        #region Helper Methods
        private void AddValuesToParameters(ref DynamicParameters parameters,
                                    ref PStudentPersonalInfoParams codes)
        {
            parameters.Add("@p_SrCode",                 codes.SrCode                );
            parameters.Add("@p_StudentNameCode",        codes.UserNameCode          );
            parameters.Add("@p_StudentAddressCode",     codes.UserAddressCode       );
            parameters.Add("@p_GuardianNameCode",       codes.GuardianNameCode      );
            parameters.Add("@p_GuardianAddressCode",    codes.GuardianAddressCode   );
        }

        private void AddValuesToParameters(ref DynamicParameters parameters,
                    ref PStudentPersonalInfoModel<RStudentPersonalInfoModel> student,
                    RequestType request)
        {
            parameters.Add("@p_SrCode",                 student.InfoModel.SrCode                );
            parameters.Add("@p_LastName",               student.InfoModel.LastName              );
            parameters.Add("@p_FirstName",              student.InfoModel.FirstName             );
            parameters.Add("@p_MiddleName",             student.InfoModel.MiddleName            );
            parameters.Add("@p_BirthDate",              student.InfoModel.BirthDate             );
            parameters.Add("@p_Gender",                 student.InfoModel.Gender                );
            parameters.Add("@p_ContactNumber",          student.InfoModel.ContactNumber         );
            parameters.Add("@p_EmailAddress",           student.InfoModel.EmailAddress          );
            parameters.Add("@p_HouseNumber",            student.InfoModel.HouseNumber           );
            parameters.Add("@p_Barangay",               student.InfoModel.Barangay              );
            parameters.Add("@p_Municipality",           student.InfoModel.Municipality          );
            parameters.Add("@p_Province",               student.InfoModel.Province              );
            parameters.Add("@p_GuardianLastName",       student.InfoModel.GuardianLastName      );
            parameters.Add("@p_GuardianFirstName",      student.InfoModel.GuardianFirstName     );
            parameters.Add("@p_GuardianMiddleName",     student.InfoModel.GuardianMiddleName    );
            parameters.Add("@p_GuardianContactNumber",  student.InfoModel.GuardianContactNumber );
            parameters.Add("@p_GuardianHouseNumber",    student.InfoModel.GuardianHouseNumber   );
            parameters.Add("@p_GuardianBarangay",       student.InfoModel.GuardianBarangay      );
            parameters.Add("@p_GuardianMunicipality",   student.InfoModel.GuardianMunicipality  );
            parameters.Add("@p_GuardianProvince",       student.InfoModel.GuardianProvince      );
            parameters.Add("@p_StudentNameCode",        student.UserId                          );
            parameters.Add("@p_StudentAddressCode",     student.UserId                          );
            parameters.Add("@p_GuardianNameCode",       student.GuardianCode                    );
            parameters.Add("@p_GuardianAddressCode",    student.GuardianCode                    );

            if (RequestType.INSERT == request)
            {
                int currentYear = DateTime.Now.Year;
                string AcademicYear = $"A.Y. {currentYear - 1}-{currentYear}";

                parameters.Add("@p_AcademicYear",       AcademicYear            );
                parameters.Add("@p_DefaultPassword",    student.DefaultPassword );
                parameters.Add("@p_Position",           student.Position        );
            }
        }
        #endregion


        private IDataRepository _repository;
        private StudentPersonalInfoQuery _query;
    }
}
