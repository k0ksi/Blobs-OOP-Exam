using Blobs.Exceptions;
using Blobs.Interfaces;
using Blobs.Models.AttackTypes;

namespace Blobs.Core.Factories
{
    public class AttackFactory : IAttackFactory
    {
        public IAttack CreateAttack(string attackType)
        {
            IAttack attack;
            switch (attackType)
            {
                case "PutridFart":
                    attack = new PutridFart();
                    return attack;
                case "Blobplode":
                    attack = new Blobplode();
                    return attack;
                default:
                    throw new AttackNotImplementedException(Messages.Messages.AttackNotImplemented);
            }
        }
    }
}