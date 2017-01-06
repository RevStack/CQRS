using System;
using System.Threading.Tasks;
using RevStack.CQRS.Command;

namespace RevStack.CQRS.CommandHandler
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task ExecuteAsync(T command);
    }
}
