using Microsoft.AspNetCore.Identity;

namespace Blog.Core.Domains.Identities
{
    public class UserRole : IdentityUserRole<string>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
