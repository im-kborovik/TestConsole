using System;
using System.Collections.Generic;

namespace Skynet.Dtos.EntityChanges
{
    public class EntityHistoryEntry
    {
        public string EntryId { get; set; }
        public Guid EntityId { get; set; }
        public Guid? UserId { get; set; }
        public string TypeOfChange { get; set; }
        public string UserFullName { get; set; }
        public DateTime ChangedAt { get; set; }
        public IReadOnlyCollection<EntityPropertyChange> Diff { get; set; }
    }
}