using Dapper;
using DomainLayer.DataModels;
using DomainLayer.DataModels.Instructor;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Presenters.Enumerations;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorPersonalInfoController : ControllerBase
    {
        public InstructorPersonalInfoController(IDataRepository dataRepository)
        {
            _repository = dataRepository;
            _query = new InstructorPersonalInfoQuery();
        }



        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            string procedure = _query.spGetAll;

            var response = await _repository.GetAll<RInstructorPersonalInfoModel>(procedure);

            if (response.Count > 0) return Ok(response);
            return NotFound(new { Message = "No instructor personal information was found." });
        }


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string itrCode)
        {
            string procedure = _query.spGetById;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@p_ItrCode",    itrCode);

            var response = await _repository.GetSingle<RInstructorPersonalInfoModel>(procedure, parameters);

            if (response != null) return Ok(response);
            return NotFound(new { Message = $"No personal information was found for instructor with code {itrCode}." });
        }


        [HttpPost("InsertNew")]
        public async Task<IActionResult> InsertNew(PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> instructorModel)
        {
            string procedure = _query.spInsert;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref instructorModel, RequestType.INSERT);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to add instructor with Itr-Code {instructorModel.InfoModel.ItrCode}" });
        }


        [HttpPost("Update")]
        public async Task<IActionResult> Update(PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> instructorModel)
        {
            string procedure = _query.spUpdate;
            
            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref instructorModel, RequestType.UPDATE);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to update instrucotr with Itr-Code {instructorModel.InfoModel.ItrCode}." });
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromBody] PInstructorPersonalInfoParams instructorModel)
        {
            string procedure = _query.spDelete;

            DynamicParameters parameters = new DynamicParameters();
            AddValuesToParameters(ref parameters, ref instructorModel);

            int response = await _repository.Execute(procedure, parameters);

            if (response != 0) return Ok(response);
            return BadRequest(new { Message = $"Failed to delete instructor with Itr-Code {instructorModel.ItrCode}." });
        }



        #region Helpers

        private void AddValuesToParameters(ref DynamicParameters parameters,
                                    ref PInstructorPersonalInfoParams codes)
        {
            parameters.Add("@p_ItrCode",                codes.ItrCode               );
            parameters.Add("@p_InstructorNameCode",     codes.UserNameCode          );
            parameters.Add("@p_InstructorAddressCode",  codes.UserAddressCode       );
            parameters.Add("@p_GuardianNameCode",       codes.GuardianNameCode      );
            parameters.Add("@p_GuardianAddressCode",    codes.GuardianAddressCode   );
        }


        private void AddValuesToParameters(ref DynamicParameters parameters, 
            ref PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> instructorModel,
            RequestType request)
        {
            parameters.Add("@p_ItrCode",                instructorModel.InfoModel.ItrCode               );
            parameters.Add("@p_LastName",               instructorModel.InfoModel.LastName              );
            parameters.Add("@p_FirstName",              instructorModel.InfoModel.FirstName             );
            parameters.Add("@p_MiddleName",             instructorModel.InfoModel.MiddleName            );
            parameters.Add("@p_BirthDate",              instructorModel.InfoModel.BirthDate             );
            parameters.Add("@p_Gender",                 instructorModel.InfoModel.Gender                );
            parameters.Add("@p_ContactNumber",          instructorModel.InfoModel.ContactNumber         );
            parameters.Add("@p_EmailAddress",           instructorModel.InfoModel.EmailAddress          );
            parameters.Add("@p_HouseNumber",            instructorModel.InfoModel.HouseNumber           );
            parameters.Add("@p_Barangay",               instructorModel.InfoModel.Barangay              );
            parameters.Add("@p_Municipality",           instructorModel.InfoModel.Municipality          );
            parameters.Add("@p_Province",               instructorModel.InfoModel.Province              );
            parameters.Add("@p_GuardianLastName",       instructorModel.InfoModel.GuardianLastName      );
            parameters.Add("@p_GuardianFirstName",      instructorModel.InfoModel.GuardianFirstName     );
            parameters.Add("@p_GuardianMiddleName",     instructorModel.InfoModel.GuardianMiddleName    );
            parameters.Add("@p_GuardianContactNumber",  instructorModel.InfoModel.GuardianContactNumber );
            parameters.Add("@p_GuardianHouseNumber",    instructorModel.InfoModel.GuardianHouseNumber   );
            parameters.Add("@p_GuardianBarangay",       instructorModel.InfoModel.GuardianBarangay      );
            parameters.Add("@p_GuardianMunicipality",   instructorModel.InfoModel.GuardianMunicipality  );
            parameters.Add("@p_GuardianProvince",       instructorModel.InfoModel.GuardianProvince      );
            parameters.Add("@p_InstructorNameCode",     instructorModel.UserId                          );
            parameters.Add("@p_InstructorAddressCode",  instructorModel.UserId                          );
            parameters.Add("@p_GuardianNameCode",       instructorModel.GuardianCode                    );
            parameters.Add("@p_GuardianAddressCode",    instructorModel.GuardianCode                    );

            if (RequestType.INSERT == request)
            {
                int currentYear = DateTime.Now.Year;
                string AcademicYear = $"A.Y. {currentYear - 1}-{currentYear}";

                parameters.Add("@p_AcademicYear",       AcademicYear                    );
                parameters.Add("@p_DefaultPassword",    instructorModel.DefaultPassword );
                parameters.Add("@p_Position",           instructorModel.Position        );
            }
        }

        #endregion


        private IDataRepository _repository;
        private InstructorPersonalInfoQuery _query;
    }
}
