using Abstractions.Commands;
using UnityEngine;
using Core;

namespace UserControlSystem
{
    internal class SetRallyPointCommandCreator : CancellableCommandCreatorBase<ISetRallyPointCommand, Vector3>
    {
        protected override ISetRallyPointCommand CreateCommand(Vector3 argument) => new SetRallyPointCommand(argument);
    }
}
