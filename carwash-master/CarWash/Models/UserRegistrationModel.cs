using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class UserRegistrationModel
    {
        public string Name { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string CarNo { get; set; }
        public string CarType { get; set; }
        public string CarColor { get; set; }
       
    }
}
