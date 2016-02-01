using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class ReportEventsCommand : Command
    {
        public ReportEventsCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
        }
    }
}