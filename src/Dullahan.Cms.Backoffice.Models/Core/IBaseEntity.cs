namespace Dullahan.Cms.Models.Core;

public interface IBaseEntity
{

    public Guid Id { get; set; }

    public Guid CreatorId { get; set; }
    public DateTimeOffset Created { get; set; }

    public Guid? ModifierId { get; set; }
    public DateTimeOffset? Modified { get; set; }
}