
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models.Dto
{
    public class MenuItemCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        public string Category { get; set; }
        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        public IFormFile File { get; set; }
    }
}
