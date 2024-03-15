using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShopManagement.Infrastructure.EFCore.IdentityContext
{
    public class IdentityDbContexts : IdentityDbContext
    {
        public IdentityDbContexts(DbContextOptions<IdentityDbContexts> options)
          : base(options)
        {

        }
    }
}
