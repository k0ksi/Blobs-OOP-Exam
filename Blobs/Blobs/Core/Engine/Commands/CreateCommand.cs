using Blobs.Attributes;
using Blobs.Interfaces;
using Blobs.Models;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class CreateCommand : Command
    {
        public CreateCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            var blobName = commandParams[0];
            var blobHealth = int.Parse(commandParams[1]);
            var blobDamage = int.Parse(commandParams[2]);
            var behaviorType = commandParams[3];
            IBehavior blobBehavior = this.Engine.BehaviorFactory.CreateBehavior(behaviorType);
            var attackType = commandParams[4];
            IAttack blobAttack = this.Engine.AttackFactory.CreateAttack(attackType);

            var blob = new Blob(blobName, blobHealth, blobDamage, blobBehavior, blobAttack);

            this.Engine.AddBlob(blob);
        }
    }
}