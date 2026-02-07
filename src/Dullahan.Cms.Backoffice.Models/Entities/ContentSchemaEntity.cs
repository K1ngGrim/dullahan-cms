using Dullahan.Cms.Models.Core;

namespace Dullahan.Cms.Models.Entities;

public class ContentSchemaEntity : ITenantScopedEntity
{
    public Guid Id { get; set; }
    public Guid CreatorId { get; set; }
    public DateTimeOffset Created { get; set; }
    public Guid? ModifierId { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public Guid TenantId { get; set; }
    public TenantEntity Tenant { get; set; }
}