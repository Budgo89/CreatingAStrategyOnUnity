using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Abstractions.Commands
{
    public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
    {
        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            Debug.Log($"{name} движется!");
        }
    }
}
