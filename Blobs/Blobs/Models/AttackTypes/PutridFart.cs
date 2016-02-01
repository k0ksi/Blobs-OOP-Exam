using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Models.AttackTypes
{
    [Attack]
    public class PutridFart : Attack
    {
        public override void ProduceAttack(IBlob target)
        {
            if (this.Attacker.IsAlive && target.IsAlive)
            {
                if (target.Health / 2 <= target.Health - this.Attacker.AttackDamage)
                {
                    target.Behavior.IsTriggered = true;
                }

                if (target.Behavior.IsTriggered)
                {
                    target.Behavior.Blob = target;
                    target.Behavior.TriggerBehavior();
                }
                
                target.Health -= this.Attacker.AttackDamage;

                if (target.Health < 0)
                {
                    target.Health = 0;
                }
            }
        }
    }
}