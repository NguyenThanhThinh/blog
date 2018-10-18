using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Blog.Core.Domains.Identities
{
    public class User : IdentityUser<string>
    {
        public string ProfilePicture { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool? IsEnabled { get; set; }

        public ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
    }
}
