using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models.Dto
{
    public class OrderHeaderCreateDto
    {
        [Required]
        public string PickupName { get; set; }
        [Required]
        public string PickupPhoneNumber { get; set; }
        [Required]
        public string PickupEmail { get; set; }
        public string ApplicationUserId { get; set; }
        public double OrderTotal { get; set; }
        public string StripePaymentIntentID { get; set; }
        public string Status { get; set; }
        public int TotalItems { get; set; }

        public IEnumerable<OrderDetailsCreateDto> OrderDetailsDTO { get; set; }
    }
}
