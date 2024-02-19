using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RedMango_API.Data;
using RedMango_API.Models;
using RedMango_API.Models.Dto;
using RedMango_API.Utility;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RedMango_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ApiResponse _response;
        private readonly UserManager<ApplicationUser> _userManager;         //to manage who is the user
        private readonly RoleManager<IdentityRole> _roleManager;            //to manage role of the user
        private string secretKey;
        public AuthController(ApplicationDbContext db,IConfiguration configuration,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
            _userManager = userManager;
            _roleManager = roleManager;
            _response = new ApiResponse();
           

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto model)
        {
            ApplicationUser userFromDb = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());
            if(userFromDb!=null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Username already exists!");
                return BadRequest(_response);
               

            }
            ApplicationUser newUser = new()
            {
                UserName = model.UserName,
                Email = model.UserName,
                NormalizedEmail = model.UserName.ToUpper(),
                Name = model.Name
            };
            var result = await _userManager.CreateAsync(newUser, model.Password);
            try
            {
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync(StorageData.Role_Admin).GetAwaiter().GetResult())  //since it is async method we have to use awaiter
                    {
                        await _roleManager.CreateAsync(new IdentityRole(StorageData.Role_Admin));
                        await _roleManager.CreateAsync(new IdentityRole(StorageData.Role_Customer));

                    }
                    if (model.Role.ToLower() == StorageData.Role_Admin)
                    {
                        await _userManager.AddToRoleAsync(newUser, StorageData.Role_Admin);
                    }
                    else
                    {
                        //if role is anything other than admin, customer role will be assigned
                        await _userManager.AddToRoleAsync(newUser, StorageData.Role_Customer);
                    }

                    _response.StatusCode = HttpStatusCode.OK;
                    _response.IsSuccess = true;
                    return Ok(_response);
                }
            }
            catch (Exception)
            {

            }
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Error while registering");
            return BadRequest(_response);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            ApplicationUser userFromDb = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == model.Username.ToLower());
            //check if password is same
            bool isValid = await _userManager.CheckPasswordAsync(userFromDb, model.Password);
            if (isValid==false)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Username or Password is incorrect!");
                return BadRequest(_response);

            }

            //if password and username is same,we have to generate JWT Token

            var roles = await _userManager.GetRolesAsync(userFromDb);           //gives the list of roles of the logged-in user
            JwtSecurityTokenHandler tokenHandler = new();
            byte[] key = Encoding.ASCII.GetBytes(secretKey);

            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Subject = new ClaimsIdentity(new Claim[]                        //within subject, we add all the properties which we want inside a token
                {
                    new Claim("fullName", userFromDb.Name),
                    new Claim("id", userFromDb.Id.ToString()),
                    new Claim(ClaimTypes.Email, userFromDb.UserName.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault()),             //since our user have only one role

                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)

            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);        //final token


            LoginResponseDto loginResponse = new()
            {
                Email = userFromDb.Email,
                Token = tokenHandler.WriteToken(token)  
                //we cannot directly assign token as Token=token since Token here is in string format so we will use WriteToken method to convert that into a string
            };
            if(loginResponse.Email==null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("Username or Password is incorrect!");
                return BadRequest(_response);

            }
            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = loginResponse;
            return Ok(_response);
        }
    }
}
