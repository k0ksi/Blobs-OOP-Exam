using Blobs.Attributes;

namespace Blobs.Models.BehaviorTypes
{
    [Behavior]
    public class InflatedBehavior : Behavior
    {
        private const int BlobHealthBoost = 50;
        private const int BlobHealthDecreasePoints = 10;
        
        public override void UpdateOnTrigger()
        {
            if (this.Blob.Health <= 0)
            {
                this.Blob.Health = 0;
            }

            this.Blob.Health += BlobHealthBoost;
        }

        public override void UpdateOnTurn()
        {
            this.Blob.Health -= BlobHealthDecreasePoints;
        }
    }
}