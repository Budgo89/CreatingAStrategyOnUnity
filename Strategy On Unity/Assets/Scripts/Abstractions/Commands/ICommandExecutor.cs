using System.Threading.Tasks;

namespace Abstractions.Commands
{
    public interface ICommandExecutor
    {
        Task ExecuteCommand(object command);
    }

    public interface ICommandExecutor<T> : ICommandExecutor where T : ICommand
    {

    }
}