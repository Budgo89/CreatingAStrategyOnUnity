using Abstractions.Commands;
using UnityEngine;

namespace Core.CommandExecutors
{
    internal class SetRallyPointCommand : ISetRallyPointCommand
    {
        public Vector3 RallyPoint { get; }
        public SetRallyPointCommand(Vector3 rallyPoint)
        {
            RallyPoint = rallyPoint;
        }

    }
}
