using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarWash.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CarWash.Entities.Configuration;

namespace CarWash.Data
{
    public class CarWashContext : IdentityDbContext<User>
    {
        public CarWashContext(DbContextOptions<CarWashContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<UserCar>()
                .HasKey(bc => new { bc.UserId, bc.CarId });

            modelBuilder.Entity<UserCar>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserCar)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserCar>()
                .HasOne(bc => bc.Car)
                .WithMany(c => c.UserCar)
                .HasForeignKey(bc => bc.CarId);
            
            modelBuilder.Entity<User>()
                .HasMany(c => c.Location)
                .WithOne(e => e.User)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(c => c.Car)
                .WithOne(e => e.User)
                .IsRequired()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            








        }



        public DbSet<CarWash.Models.Car> Car { get; set; }
        public DbSet<CarWash.Models.User> User { get; set; }
        public DbSet<CarWash.Models.Reservation> Reservation { get; set; }
        public DbSet<CarWash.Models.UserCar> UserCar { get; set; }
        public DbSet<CarWash.Models.Location> Location { get; set; }
        public DbSet<CarWash.Models.Types> Types { get; set; }




    }
}
