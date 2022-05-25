using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using Core.CommandExecutors;
using UnityEngine;
using Zenject;

namespace Core
{
    internal class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
    {
        [Inject]
        CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;

        public void Clear() { }
        public async void EnqueueCommand(object command)
        {
            await _produceUnitCommandExecutor.ExecuteCommand(command);
        }

    }
}
