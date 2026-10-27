using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class AuditLog : BaseEntity
    {
        public int? UserId { get; set; }
        public string? UserName { get; set; }

        public AuditActionType ActionType { get; set; }
        public string EntityName { get; set; } = null!;
        public int EntityId { get; set; }

        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? Description { get; set; }
    }
}
