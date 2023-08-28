using DataLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Contains actions for working with user
    /// </summary>
    [Route("api/user")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;

        public UserController(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserInfo()
        {
            //return Ok(await _unitOfWork.GetUserInfoAsync(await _userManager.FindByNameAsync(User.Identity.Name)));
            throw new NotImplementedException();
        }
    }
}
