using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class User : IdentityUser
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public string CarNo { get; set; }
        public string CarType { get; set; }
        public string Colour { get; set; }
       

        public ICollection<Location> Location { get; set; }
        public ICollection<Car> Car { get; set; }
        

        public IList<UserCar> UserCar { get; set; }

    }
}
