using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        public string Day { get; set; }
        public double Amount { get; set; }
        
        public bool Vacuum { get; set; }
        public bool Leatherconditioner { get; set; }
        public bool Polish { get; set; }
        public bool Freshner { get; set; }
        public bool Amortires { get; set; }
        public bool Enginewash { get; set; }
        public string Payment { get; set; }
        public string Answer { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Comment { get; set; }
        public DateTime dateCreated { get; set; }

       


        public int CarId { get; set; }
        public Car Car { get; set; }

        public int TypesId { get; set; }
        public Types Types { get; set; }
        
    }
}
