using System.Threading.Tasks;
using RevStack.CQRS.Command;

namespace RevStack.CQRS.Messaging
{
    public interface ICommandBus
    {
        Task<ICommandPublishResponse> ExecuteAsync<T>(T command) where T : ICommand;
    }
}
