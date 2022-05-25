using UnityEngine;

namespace Abstractions.Commands
{
    public interface ISetRallyPointCommand : ICommand
    {
        Vector3 RallyPoint { get; }
    }

}
