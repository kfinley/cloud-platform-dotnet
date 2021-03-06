using System;

namespace CloudPlatform.Entities {
  public abstract class BaseEntity : IEntity {
    public Guid Id { get; set; }
    public EntityStatus Status { get; set; }
    public DateTime DateCreated { get; set; }
  }
}
