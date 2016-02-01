using Blobs.Attributes;

namespace Blobs.Models.BehaviorTypes
{
    [Behavior]
    public class AggresiveBehavior : Behavior
    {
        private const int BlobAttackBoostMultiplier = 2;
        private const int BlobAttackDecreasePoints = 5;

        public int AttackDamageInitialValue { get; private set; }

        public override void UpdateOnTrigger()
        {
            if (this.Blob.Health <= 0)
            {
                this.Blob.Health = 0;
            }

            this.AttackDamageInitialValue = this.Blob.AttackDamage;
            this.Blob.AttackDamage *= BlobAttackBoostMultiplier;
        }

        public override void UpdateOnTurn()
        {
            if (this.Blob.AttackDamage - BlobAttackDecreasePoints >= AttackDamageInitialValue)
            {
                this.Blob.AttackDamage -= BlobAttackDecreasePoints;
            }
        }
    }
}