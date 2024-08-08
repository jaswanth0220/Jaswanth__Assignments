using HandsOnApiUsingEntityFrameWork.Entities;
using HandsOnApiUsingEntityFrameWork.Models;
using HandsOnApiUsingEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HandsOnApiUsingEntityFrameWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private IConfiguration _configuration;
        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            this.userRepository = userRepository;
            _configuration = configuration;
        }

        //public UserController()
        //{
        //    userRepository = new UserRepository();
        //}


        [HttpPost,Route("Register")]
        [AllowAnonymous]
        public IActionResult Register(User user)
        {
            userRepository.Register(user);
            return StatusCode(200, user);
        }

        //[HttpGet, Route("GetUser")]
        //public IActionResult Get([FromQuery]string email, [FromQuery]string password)
        //{
        //    var user = userRepository.ValidUser(email,password);
        //    if (user == null)
        //    {
        //        return StatusCode(404, "credentials are incorrect");
        //    }
        //    return Ok(user);
        //}

        // other way to get the user

        [HttpPost,Route("Validate")]
        [AllowAnonymous]
        public IActionResult ValidUser(Login login)
        {
            AuthResponse authResponse = null;
            var user = userRepository.ValidUser(login.Email,login.Password);
            if (user != null)
            {
                authResponse = new AuthResponse()
                {
                    UserId = user.UserId,
                    Role = user.Role,
                    Token = GetToken(user),
                };
            }
            return Ok(authResponse);
        }

        private string GetToken(User user)
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
            //Header section
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            );
            //Payload section
            var subject = new ClaimsIdentity(new[]
            {
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Role, user.Role),
                    });

            var expires = DateTime.UtcNow.AddMinutes(10);//token will expire after 10min

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };
            //generate token using tokenDescription
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }


    }
}
