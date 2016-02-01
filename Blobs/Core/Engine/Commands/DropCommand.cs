using System;
using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class DropCommand : Command
    {
        public DropCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            Environment.Exit(0);
        }
    }
}