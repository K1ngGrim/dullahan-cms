using Dullahan.Cms.Models.Core;

namespace Dullahan.Cms.Models.Entities;

public class ContentSchemaEntryEntity : IBaseEntity
{
    public Guid Id { get; set; }
    public Guid CreatorId { get; set; }
    public DateTimeOffset Created { get; set; }
    public Guid? ModifierId { get; set; }
    public DateTimeOffset? Modified { get; set; }

    /**
     * Schema entries are organized in a tree structure. The ParentSchemaId and ParentId properties represent the parent-child relationships between schema entries.
     * ParentSchemaId refers to the parent schema, while ParentId refers to the parent entry within that schema.
     * This allows for a hierarchical organization of content schema entries, enabling complex structures and relationships between different entries.
     */
    public Guid ParentSchemaId { get; set; }
    public ContentSchemaEntity ParentSchema { get; set; }

    /**
     * ParentId is a self-referential foreign key that allows for the creation of a hierarchical structure of content schema entries. Each entry can have a parent entry, and this relationship is represented by the ParentId property.
     * The Parent property is a navigation property that allows for easy access to the parent entry's details.
     * This design enables the organization of content schema entries in a tree-like structure, facilitating complex relationships and hierarchies within the content management system.
     */
    public Guid ParentId { get; set; }
    public ContentSchemaEntryEntity Parent { get; set; }




}

public enum ContentType {
    String,
    Number,
    Boolean,
    DateTime,
    Object,
    Array
}