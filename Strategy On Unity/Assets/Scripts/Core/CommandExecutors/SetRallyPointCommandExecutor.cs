using System.Threading.Tasks;
using Abstractions.Commands;

namespace Core.CommandExecutors
{
    internal class SetRallyPointCommandExecutor : CommandExecutorBase<ISetRallyPointCommand>
    {
        public override async Task ExecuteSpecificCommand(ISetRallyPointCommand command)
        {
            GetComponent<MainBuilding>().RallyPoint = command.RallyPoint;
        }

    }
}
