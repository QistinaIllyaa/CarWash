using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public DayOfWeek Day { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Ipaddress { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        



    }
}
