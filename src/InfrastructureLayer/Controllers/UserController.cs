
using Dapper;
using DomainLayer.DataModels;
using InfrastructureLayer.Database;
using InfrastructureLayer.Query;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController(IDataRepository dataRepository)
        {
            _query = new UserQuery();
            _repository = dataRepository;
        }


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string UserId)
        {
            string procedure = _query.GetById;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@p_userId", UserId, DbType.String);

            var user = await _repository.GetSingle<PRUserModel>(procedure, parameters);

            if (user is not null) return Ok(user);
            else return NotFound(new { Message = $"No user with ID {UserId} was found." });
        }


        private UserQuery _query;
        private IDataRepository _repository;
    }
}
