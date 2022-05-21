using Abstractions.Commands;
using UnityEngine;
using System.Threading.Tasks;

namespace Core.CommandExecutors
{
    public abstract class CommandExecutorBase<T> : MonoBehaviour, ICommandExecutor<T> where T : ICommand
    {
        //public void ExecuteCommand(object command) => ExecuteSpecificCommand((T) command);

        public abstract Task ExecuteSpecificCommand(T command);

        public async Task ExecuteCommand(object command)
        {
            var specificCommand = (T) command;
            if (specificCommand != null)
            {
                await ExecuteSpecificCommand(specificCommand);
            }
        }
    }
}