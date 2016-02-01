using System.Linq;
using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Core.Engine.Commands
{
    [Command]
    public class AttackCommand : Command
    {
        public AttackCommand(IEngine engine) 
            : base(engine)
        {
        }

        public override void Execute(params string[] commandParams)
        {
            var attackerName = commandParams[0];
            var targetName = commandParams[1];
            var attacker = this.Engine.Blobs
                .FirstOrDefault(x => x.Name == attackerName);
            var target = this.Engine.Blobs
                .FirstOrDefault(x => x.Name == targetName);

            attacker.AttackType.Attacker = attacker;
            attacker.AttackType.ProduceAttack(target);
        }
    }
}