using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models
{
    public class ShoppingCart
    {

        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<CartItem> CartItems { get; set; }

        [NotMapped]                             //NotMapped means the property will be in model but not adds column in table
        public double CartTotal { get; set; }

        //when customer checks out goes to payment gateway it will give a secret id which will be used to checkout
        //these two columns will be used for that
        [NotMapped]
        public string StripePaymentIntentId { get; set; }               
        [NotMapped]
        public string ClientSecret { get; set; }
    
    }
}
