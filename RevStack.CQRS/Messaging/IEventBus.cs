using RevStack.CQRS.Event;

namespace RevStack.CQRS.Messaging
{
    public interface IEventBus
    {
        void RaiseEvent<T>(T @event) where T : IEvent;
    }
}
