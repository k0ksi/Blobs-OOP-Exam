using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class PassCommand : Command
    {
        public PassCommand(IEngine engine) 
            : base(engine)
        {
        }

        // Does nothing, skips the turn and progresses the game
        public override void Execute(params string[] commandParams)
        {
        }
    }
}