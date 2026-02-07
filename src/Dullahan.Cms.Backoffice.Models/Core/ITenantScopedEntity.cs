using Dullahan.Cms.Models.Entities;

namespace Dullahan.Cms.Models.Core;

public interface ITenantScopedEntity : IBaseEntity
{
    public Guid TenantId { get; set; }

    public TenantEntity Tenant { get; set; }
}