﻿using System;
using System.Threading.Tasks;


namespace RevStack.CQRS.Storage
{
    public interface ISnapshotStore
    {
        int SnapshotFrequency { get; }
        Task<Snapshot.Snapshot> GetSnapshotAsync(Type aggregateType, Guid aggregateId);
        Task SaveSnapshotAsync(Type aggregateType, Snapshot.Snapshot snapshot);
    }
}
