using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
    }
}
