using System.Threading.Tasks;
using RevStack.CQRS.Event;

namespace RevStack.CQRS.EventHandler
{
    public interface IEventHandler<T> where T : IEvent
    {
        Task HandleEventAsync(T @event);
    }
}
