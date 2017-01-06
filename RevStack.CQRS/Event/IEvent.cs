using System;
using RevStack.CQRS.Message;


namespace RevStack.CQRS.Event
{
    public interface IEvent : IMessage
    {
        Guid AggregateId { get; set; }
        int Version { get; set; }
        DateTime EventCommittedTimestamp { get; set; }
    }
}
