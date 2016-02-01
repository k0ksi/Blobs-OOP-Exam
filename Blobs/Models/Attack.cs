using Blobs.Exceptions;
using Blobs.Interfaces;

namespace Blobs.Models
{
    public abstract class Attack : IAttack
    {
        private IBlob attacker;
        
        public IBlob Attacker
        {
            get { return this.attacker; }
            set
            {
                if (value == null)
                {
                    throw new GameObjectPropertyNullException(string.Format(Messages.Messages.ObjectNull,
                        nameof(this.attacker)));
                }

                this.attacker = value;
            }
        }
        
        public abstract void ProduceAttack(IBlob target);
    }
}