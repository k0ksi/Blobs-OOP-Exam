using Blobs.Attributes;
using Blobs.Interfaces;

namespace Blobs.Models.AttackTypes
{
    [Attack]
    public class Blobplode : Attack
    {
        private const int HealthPointsReductor = 2;
        private const int AttackDamageMultiplier = 2;

        public override void ProduceAttack(IBlob target)
        {
            if (this.Attacker.IsAlive && target.IsAlive)
            {
                var initialHealth = this.Attacker.Health;
                this.Attacker.Health -= (this.Attacker.Health / HealthPointsReductor);

                if (this.Attacker.Health <= (initialHealth/ HealthPointsReductor))
                {
                    this.Attacker.Behavior.IsTriggered = true;
                }

                if (this.Attacker.Behavior.IsTriggered)
                {
                    this.Attacker.Behavior.Blob = this.Attacker;
                    this.Attacker.Behavior.TriggerBehavior();
                }

                var prevTargetHealth = target.Health;
                target.Health -= this.Attacker.AttackDamage * AttackDamageMultiplier;
                if (target.Health < 0)
                {
                    target.Health = 0;
                }

                if (target.Health <= prevTargetHealth / 2)
                {
                    target.Behavior.IsTriggered = true;
                }

                if (target.Behavior.IsTriggered)
                {
                    target.Behavior.Blob = target;
                    target.Behavior.TriggerBehavior();
                }
            }
        }
    }
}