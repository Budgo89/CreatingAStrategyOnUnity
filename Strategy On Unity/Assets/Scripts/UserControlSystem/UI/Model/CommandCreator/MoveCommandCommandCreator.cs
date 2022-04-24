using System;
using Abstractions.Commands.CommandsInterfaces;

namespace UserControlSystem.UI.Model.CommandCreator
{
    public class MoveCommandCommandCreator : CommandCreatorBase<IMoveCommand>
    {
        protected override void ClassSpecificCommandCreation(Action<IMoveCommand> creationCallback)
        {
            throw new NotImplementedException();
        }
    }
}
