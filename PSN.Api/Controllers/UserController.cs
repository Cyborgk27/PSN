using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSN.Infrastructure.Persistence.Interfaces;

namespace PSN.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _unitOfWork.User.GetByIdAsync(userId);
            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
