using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedMango_API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Controllers
{
    [Route("api/AuthTest")]
    [ApiController]
    public class AuthTestController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<string>> GetSomething()
        {
            return "You are authenticated";
        }
        [HttpGet("{id:int}")]
        [Authorize(Roles =StorageData.Role_Admin)]
        public async Task<ActionResult<string>> GetSomething(int someIntValue)          //this function will only be authorized to admins
        {
            return "You are authorized the role of admin";
        }

    }
}
