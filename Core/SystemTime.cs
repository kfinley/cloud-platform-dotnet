using System;

namespace CloudPlatform.Core {
  public static class SystemTime {
    public static DateTime UtcNow => DateTime.UtcNow;
    public static DateTime Now => DateTime.Now;
  }
}
