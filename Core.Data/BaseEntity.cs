using System;

namespace CloudPlatform.Core.Data {
  public abstract class BaseEntity : IEntity {
    public Guid Id { get; set; }
    public EntityStatus Status { get; set; }
    public DateTime DateCreated { get; set; }
  }
}
