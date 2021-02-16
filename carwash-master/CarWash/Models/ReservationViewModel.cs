using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class ReservationViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public DateTime Date { get; set; }

        public string Day { get; set; }
        public float Amount { get; set; }

        public bool Vacuum { get; set; }
        public bool Leatherconditioner { get; set; }
        public bool Polish { get; set; }
        public bool Freshner { get; set; }
        public bool Amortires { get; set; }
        public bool Enginewash { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Price { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int TypesId { get; set; }
        public Types Types { get; set; }
    }
}

