using System;
using System.Collections.Generic;

#nullable disable

namespace KartSkills.Models
{
    public partial class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdRole { get; set; }

    }
}
