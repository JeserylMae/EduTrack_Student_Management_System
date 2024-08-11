
using InfrastructureLayer.Database;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        //  private readonly ApiService _apiService;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var _userList = await _userRepo.GetAll();

        //    //if (_userList is not null)
        //    //{
        //    //    for (int i = 0; i < _userList.Count; i++)
        //    //    {
        //    //        Console.WriteLine($"UserId: {_userList[i].UserId}");
        //    //    }
        //    //    return Ok(_userList);
        //    //}
        //    if (_userList is not null) return Ok(_userList);
        //    else return NotFound();
        //}

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string UserId)
        {
            var user = await _userRepository.GetById(UserId);

            // if (user is not null)   return Ok(user);
            if (user is not null) return Ok(user);
            else return NotFound(new { Message = $"No user with ID {UserId} was found." });
        }

        // do {$response = Invoke-WebRequest -Uri "https://localhost:5176/health" -UseBasicParsing Start-Sleep -Seconds 2} until($response.StatusCode -eq 200) Write-Output "API is ready"


        //[HttpPost("InsertNew")]
        //public async Task<IActionResult> InsertNew(UserModel user)
        //{
        //    var response = await _userRepo.InsertNew(user);

        //    if (response is not 0)  return Ok(new { Message = $"Successfully added user {user.UserId}." });
        //    else                    return BadRequest( new { Message = $"Failed to add user {user.UserId}." });
        //}

        //[HttpPost("UpdateAccount")]
        //public async Task<IActionResult> UpdateAccount(UserModel user)
        //{
        //    var response = await _userRepo.UpdateAccountPassword(user);

        //    if (response is not 0) return Ok(new { Message = $"Successfully updated user {user.UserId}." });
        //    else return BadRequest(new { Message = $"Failed to update user {user.UserId}." });
        //}


        ///////////////////////////////////////////////////////////////////////////////////////////
        ///
        ///////////////////////////////////////////////////////////////////////////////////////////

        //private readonly ApiService _apiService;

        //public UserController(ApiService apiService)
        //{
        //    _apiService = apiService;
        //}

        //public async Task<IActionResult> GetAll()
        //{
        //    var users = await _apiService.GetAllUsersAsync();
        //    return View(users);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(UserModel user)
        //{
        //    await _apiService.InsertUserAsync(user);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Delete(string userId)
        //{
        //    await _apiService.DeleteUserAsync(userId);
        //    return RedirectToAction("Index");
        //}

        //// INSTALL THIS
        //// Microsoft.AspNet.WebApi.Client

        //// EXAMPLE OF REDIRECTION
        ////[HttpPost("UpdateAccount")]
        ////public async Task<IActionResult> UpdateAccount(UserModel user)
        ////{
        ////    var response = await _userRepo.UpdateAccountPassword(user);

        ////    if (response != 0)
        ////    {
        ////        // Successfully updated, redirecting to another action
        ////        TempData["Message"] = $"Successfully updated user {user.UserId}.";
        ////        return RedirectToAction("AccountDetails", new { userId = user.UserId });
        ////    }
        ////    else
        ////    {
        ////        // Failed to update, redirecting to another action or returning BadRequest
        ////        TempData["ErrorMessage"] = $"Failed to update user {user.UserId}.";
        ////        return RedirectToAction("EditAccount", new { userId = user.UserId });
        ////    }
        ////}


        //[HttpDelete("DeleteUser")]
        //public async Task<IActionResult> DeleteUser(string UserId)
        //{
        //    var response = await _userRepo.DeleteUser(UserId);

        //    if (response is not 0)  return Ok(new { Message = $"Successfully deleted user {UserId}." });
        //    else                    return BadRequest(new { Message = $"Failed to delete user {UserId}." });
        //}
    }
}
