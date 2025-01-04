
using InfrastructureLayer.Database;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndpointController : ControllerBase
    {
        public EndpointController(IDataRepository dataRepository)
        {
            _repository = dataRepository;
        }

        [HttpGet("Health")]
        public async Task<IActionResult> HealthAsync()
        {
            int result = await _repository.CheckDatabaseConnection();

            if (result == 1) return Ok(result);
            else return BadRequest("Database connection failed.");
        }


        private IDataRepository _repository;
    }
}
