using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models.Dto
{
    public class LoginResponseDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
