using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class Volunteer
    {
        public string IdVolunteer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCountry { get; set; }
        public string GenderId { get; set; }
    }
}
