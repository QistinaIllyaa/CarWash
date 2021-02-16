
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Models
{
    public class Select2ViewModel
    {
        [JsonProperty(PropertyName = "text")]
        public string text { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "selected")]
        public bool selected { get; set; }
    }

    public class Select2ViewModelComparer : IEqualityComparer<Select2ViewModel>
    {
        // Products are equal if their names and product numbers are equal.
        public bool Equals(Select2ViewModel x, Select2ViewModel y)
        {

            if (string.Equals(x.text, y.text, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(Select2ViewModel obj)
        {
            return obj.text.GetHashCode();
        }
    }
}
