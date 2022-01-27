using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Racer
    {
        public int IdRacer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdCountry { get; set; }
    }
}
