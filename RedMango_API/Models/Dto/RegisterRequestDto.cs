using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models.Dto
{
    public class RegisterRequestDto
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
