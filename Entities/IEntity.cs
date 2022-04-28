using System;

namespace CloudPlatform.Entities {
  public interface IEntity {
    Guid Id { get; set; }
    EntityStatus Status { get; set; }
    DateTime DateCreated { get; set; }
  }
}
