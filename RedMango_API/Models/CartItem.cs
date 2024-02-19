﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; } 
        public int Quantity { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
