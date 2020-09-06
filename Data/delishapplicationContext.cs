using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using delishapplication.Models;

namespace delishapplication.Models
{
    public class delishapplicationContext : DbContext
    {
        public delishapplicationContext (DbContextOptions<delishapplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishOrder>().HasKey(po => new { po.DishID, po.OrderID });
            modelBuilder.Entity<DishOrder>().HasOne(po => po.Dish)
                .WithMany(o => o.DishOrder)
                .HasForeignKey(po => po.DishID);

            modelBuilder.Entity<DishOrder>().HasOne(po => po.Order)
          .WithMany(o => o.DishOrder)
          .HasForeignKey(po => po.OrderID);
        }
        public DbSet<delishapplication.Models.Chef> Chef { get; set; }
        public DbSet<delishapplication.Models.Dish> Dish { get; set; }
        public DbSet<delishapplication.Models.Client> Client { get; set; }
        public DbSet<delishapplication.Models.DishOrder> DishOrder { get; set; }
        public DbSet<delishapplication.Models.Order> Order { get; set; }
        public DbSet<delishapplication.Models.Branch> Branch { get; set; }
    }
}
