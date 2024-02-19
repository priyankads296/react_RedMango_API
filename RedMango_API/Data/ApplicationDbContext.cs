using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedMango_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Spring Roll",
                Description = "A burst of flavor in every bite, perfect for savoring the season!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/spring roll.jpg",
                Price = 70,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 2,
                Name = "Idli",
                Description = "Elevate your taste buds with our fluffy idlis.",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/idli.jpg",
                Price = 55,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 3,
                Name = "Pani Puri",
                Description = "Experience the explosion of flavours with our tangy Panipuris.",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/pani puri.jpg",
                Price = 50,
                Category = "Appetizer",
                SpecialTag = "Best Seller"
            }, new MenuItem
            {
                Id = 4,
                Name = "Hakka Noodles",
                Description = "Satisfy your cravings with our slurp-worthy noodles!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/hakka noodles.jpg",
                Price = 150,
                Category = "Entrée",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 5,
                Name = "Malai Kofta",
                Description = "Indulge in the richness of our creamy explosion of taste!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/malai kofta.jpg",
                Price = 250,
                Category = "Entrée",
                SpecialTag = "Top Rated"
            }, new MenuItem
            {
                Id = 6,
                Name = "Paneer Pizza",
                Description = "Get a taste of India in this fusion delicacy!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/paneer pizza.jpg",
                Price = 250,
                Category = "Entrée",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 7,
                Name = "Paneer Tikka",
                Description = "Grilled to Perfection!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/paneer tikka.jpg",
                Price = 215,
                Category = "Entrée",
                SpecialTag = "Chef's Special"
            }, new MenuItem
            {
                Id = 8,
                Name = "Carrot Love",
                Description = "Delight your senses with our decadent Carrot heaven!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/carrot%20love.jpg",
                Price = 200,
                Category = "Dessert",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 9,
                Name = "Rasmalai",
                Description = "Dive into bowl of pure bliss with our velvety Rasmalai!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/rasmalai.jpg",
                Price = 100,
                Category = "Dessert",
                SpecialTag = "Chef's Special"
            }, new MenuItem
            {
                Id = 10,
                Name = "Sweet Rolls",
                Description = "Roll into sweetness with our irresistable Sweet Rolls!",
                Image = "https://redmangoimgs.blob.core.windows.net/redmango/sweet rolls.jpg",
                Price = 150,
                Category = "Dessert",
                SpecialTag = "Top Rated"
            });
        }
    }
}
