using Dullahan.Cms.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dullahan.Cms.Models;

public partial class CoreContext(DbContextOptions options) : IdentityDbContext <
    TenantUserEntity,
    IdentityRole<Guid>,
    Guid
>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("core");

        OnIdentityCreating(builder);
        OnBackOfficeCreating(builder);
    }

}