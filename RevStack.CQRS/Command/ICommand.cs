using System;
using RevStack.CQRS.Message;


namespace RevStack.CQRS.Command
{
    public interface ICommand : IMessage
    {
        Guid AggregateId { get; }
    }
}
