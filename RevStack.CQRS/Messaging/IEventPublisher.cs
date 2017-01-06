using System.Threading.Tasks;
using RevStack.CQRS.Event;

namespace RevStack.CQRS.Messaging
{
    public interface IEventPublisher
    {
        Task PublishAsync(IEvent @event);
    }
}
