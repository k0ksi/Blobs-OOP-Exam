using System.Text;
using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class StatusCommand : Command
    {
        public StatusCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            var gameInfo = new StringBuilder();

            foreach (var blob in this.Engine.Blobs)
            {
                gameInfo.AppendLine(blob.ToString());
            }

            this.Engine.Render(gameInfo.ToString());
        }
    }
}