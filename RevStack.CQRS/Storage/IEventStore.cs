using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RevStack.CQRS.Domain;
using RevStack.CQRS.Event;

namespace RevStack.CQRS.Storage
{
    public interface IEventStore
    {
        Task<IEnumerable<IEvent>> GetEventsAsync(Type aggregateType, Guid aggregateId, int start, int count);
        Task<IEvent> GetLastEventAsync(Type aggregateType, Guid aggregateId);
        Task CommitChangesAsync(AggregateBase aggregate);
    }
}
