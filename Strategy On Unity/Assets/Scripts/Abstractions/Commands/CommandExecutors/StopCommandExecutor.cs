using System.Threading;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Abstractions.Commands.CommandExecutors
{
    public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
    {
        public CancellationTokenSource CancellationTokenSource { get; set; }


        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            CancellationTokenSource?.Cancel();
        }
    }
}