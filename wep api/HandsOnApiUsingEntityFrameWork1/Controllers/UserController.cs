using HandsOnApiUsingEntityFrameWork.Entities;
using HandsOnApiUsingEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEntityFrameWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }


        [HttpPost,Route("Register")]
        public IActionResult Register(User user)
        {
            userRepository.Register(user);
            return StatusCode(200, user);
        }

        [HttpGet, Route("GetUser")]
        public IActionResult Get([FromQuery]string email, [FromQuery]string password)
        {
            var user = userRepository.ValidUser(email,password);
            if (user == null)
            {
                return StatusCode(404, "credentials are incorrect");
            }
            return Ok(user);
        }
    }
}
