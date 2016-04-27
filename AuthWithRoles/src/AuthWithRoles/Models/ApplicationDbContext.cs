using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthWithRoles.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}