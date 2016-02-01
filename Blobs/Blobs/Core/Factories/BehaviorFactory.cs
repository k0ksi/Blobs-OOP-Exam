using Blobs.Exceptions;
using Blobs.Interfaces;
using Blobs.Models.BehaviorTypes;

namespace Blobs.Core.Factories
{
    public class BehaviorFactory : IBehaviorFactory
    {
        public IBehavior CreateBehavior(string behaviorType)
        {
            IBehavior behavior;

            switch (behaviorType)
            {
                case "Aggressive":
                    behavior = new AggresiveBehavior();
                    return behavior;
                case "Inflated":
                    behavior = new InflatedBehavior();
                    return behavior;
                default:
                    throw new BehaviorNotImplementedException(Messages.Messages.BehaviorNotImplemented);
            }
        }
    }
}