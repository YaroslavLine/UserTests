using Microsoft.AspNetCore.Identity;

namespace UserTests.Models
{
    public class AppUser : IdentityUser
    {
        public IEnumerable<AppUserTestJunction> UserTests { get; set; }
    }
}