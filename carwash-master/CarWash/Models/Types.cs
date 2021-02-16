using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarWash.Models
{
    public class Types
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Click the prices")]
        public string Services { get; set; }

        public double Prices { get; set; }
         
       

        public ICollection<Reservation> Reservations { get; set; }
    }
}