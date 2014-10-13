using System;
using System.Collections.Generic;

using System.Text;

namespace Indeks.Data.BusinessObjects
{
  public class AuditLogRecord
  {
    public long Id;
    public string Message;
    public long EntityId;
    public Type EntityType;
    public int UserId;
    public DateTime Created;
    internal AuditLogRecord() { }
    public AuditLogRecord(string message, long entityId, Type entityType, int userId)
    {
      this.Message = message; this.EntityId = entityId; this.EntityType = entityType; this.UserId = userId;
    }
  }
}
