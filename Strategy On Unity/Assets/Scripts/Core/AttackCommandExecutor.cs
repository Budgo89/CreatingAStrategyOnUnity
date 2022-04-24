using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Abstractions.Commands
{
    public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            Debug.Log($"{name} в атаку!");
        }
    }
}
