using Dullahan.Cms.Models.Core;
using Microsoft.AspNetCore.Identity;

namespace Dullahan.Cms.Models.Entities.Identity;

public class TenantUserEntity : IdentityUser<Guid>, ITenantScopedEntity
{
    public Guid CreatorId { get; set; }
    public DateTimeOffset Created { get; set; }
    public Guid? ModifierId { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public Guid TenantId { get; set; }
    public TenantEntity Tenant { get; set; }
}