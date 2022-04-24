using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Abstractions.Commands
{
    public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            Debug.Log($"{name} патрулирует из {command.From} в {command.To}!");
        }
    }
}
