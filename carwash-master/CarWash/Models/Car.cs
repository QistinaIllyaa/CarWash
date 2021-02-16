using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class Car
    {      
        public int Id { get; set;}

        [Display(Name = "Plate Number")]
        [Required]
        [MaxLength(50, ErrorMessage = ("Name cannot exceed 50 characters"))]
        public string CarNo { get; set; }

        public string CarColor { get; set; }
        public string CarType { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public IList<UserCar> UserCar { get; set; }
        public ICollection<Reservation> Reservation { get; set; }

       
       





    }
}
