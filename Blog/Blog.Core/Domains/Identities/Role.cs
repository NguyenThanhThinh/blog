using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Blog.Core.Domains.Identities
{
    public class Role : IdentityRole<long>
    {
        public ICollection<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
