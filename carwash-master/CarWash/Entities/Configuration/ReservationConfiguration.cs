using CarWash.Data;
using CarWash.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Entities.Configuration
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");
            builder.HasOne(x => x.Car)
                .WithMany(x => x.Reservation)
                .HasForeignKey(x => x.CarId);

           

            builder.Property(x => x.Address)
                .HasMaxLength(50)
                .IsRequired();

            



        }
    }
}
